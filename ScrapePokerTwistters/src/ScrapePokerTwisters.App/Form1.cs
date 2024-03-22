using OpenScrape.App;
using ScrapePokerTwisters.App.Domain.Entities.Regions;
using ScrapePokerTwisters.App.Interfaces;
using ScrapePokerTwisters.App.Aplication.UseCases.Maps;
using ScrapePokerTwisters.App.Aplication.UseCases.Images;
using ScrapePokerTwisters.App.Aplication.Helpers;
using System.Windows.Forms;


namespace ScrapePokerTwistters
{
    public partial class Form1 : Form, IAddRegion
    {
        #region Forms
        FormRegions _formRegions;
        FormImage _formImage;
        Graphics _papel;
        #endregion


        #region Regions

        List<Regions> _regions = new List<Regions>();
        List<ImageRegion> _images = new List<ImageRegion>();
        List<ImageRegion> _imagesBoard = new List<ImageRegion>();
        List<FontRegion> _fonts = new List<FontRegion>();
        Regions _locRegion = new Regions();
        ImageRegion _locImage = new ImageRegion();

        #endregion

        #region UseCases

        static readonly IGetHashImageUseCase _getHashImageUseCase = new GetHashImageUseCase();
        static readonly IGetCropImageUseCase _getCropImageUseCase = new GetCropImageUseCase();

        #endregion

        Image? _img = null;

        List<KeyValuePair<string, string>> _imageList = new List<KeyValuePair<string, string>>();


        private string Key = "8UHjPgXZzXCGkhxV2QCnooyJexUzvJrO";

        private readonly ISaveTableMapUseCase _saveUseCase = new SaveTableMapUseCase();
        private readonly ILoadTableMapUseCase _loadUseCase = new LoadTableMapUseCase();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            var response = _loadUseCase.Execute(Key);

            _regions.Clear();
            _images.Clear();
            _fonts.Clear();
            _imagesBoard.Clear();

            _regions.AddRange(response.Regions);
            _images.AddRange(response.Images);
            _imagesBoard.AddRange(response.Board);
            _fonts.AddRange(response.Fonts);

            foreach (var item in response.Tree)
            {
                var node = twRegions.Nodes.Find(item.Key, true).FirstOrDefault() as TreeNode;

                if (node != null)
                    node.Nodes.Add(item.Value);

            }

            foreach (var item in _images)
            {
                _imageList.Add(new KeyValuePair<string, string>(item.Name, item.Value));
            }
        }

        private void btnSaveMap_Click(object sender, EventArgs e)
        {
            _saveUseCase.Execute(new SaveTableMapUseCaseRequest { Regions = _regions, Images = _images, Key = Key, Board = _imagesBoard, Fonts = _fonts });
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _formRegions = new FormRegions();

            _formRegions.region = this;
            _formRegions.Show();
        }

        public void Execute(string texto, string nodo)
        {
            if (nodo == "Image")
                nodo = _locRegion.IsBoard ? "Nodo1" : "Nodo2";

            var node = twRegions.Nodes.Find(nodo, true).FirstOrDefault() as TreeNode;
            var type = string.Empty;
            Bitmap img = null;

            switch (nodo)
            {
                case "Nodo0":
                    _locRegion = new Regions { Name = texto, Type = "r" };
                    _regions.Add(_locRegion);
                    break;
                case "Nodo1":
                    texto = $"{texto} ({_locRegion.Width}x{_locRegion.Height})";
                    img = _getCropImageUseCase.Execute(new GetCropImageUseCaseRequest { Source = new Bitmap(_formImage.pbImagen.Image), Section = new Rectangle(_locRegion.X, _locRegion.Y, _locRegion.Width, _locRegion.Height) }).Image;
                    _locImage = new ImageRegion { Name = texto, Image = img, IsBoard = true };
                    _imagesBoard.Add(_locImage);
                    break;
                case "Nodo2":
                    texto = $"{texto} ({_locRegion.Width}x{_locRegion.Height})";
                    img = _getCropImageUseCase.Execute(new GetCropImageUseCaseRequest { Source = new Bitmap(_formImage.pbImagen.Image), Section = new Rectangle(_locRegion.X, _locRegion.Y, _locRegion.Width, _locRegion.Height) }).Image;
                    _locImage = new ImageRegion { Name = texto, Image = img, IsBoard = false, Value = GetValueImage(), Force = GetForceHand(texto), Suit = GetSuitHand(texto) };
                    _images.Add(_locImage);
                    break;
                case "Nodo3":
                    var imageBmp = _getCropImageUseCase.Execute(new GetCropImageUseCaseRequest { Source = new Bitmap(_formImage.pbImagen.Image), Section = new Rectangle(_locRegion.X, _locRegion.Y, _locRegion.Width, _locRegion.Height) }).Image;
                    _fonts.Add(new FontRegion { Name = texto, Value = GetHashFont(CaptureWindowsHelper.BinaryImage(imageBmp, 200), true) });
                    break;

                default:
                    break;
            }

            node.Nodes.Add(texto);
            twRegions.ExpandAll();
        }

        public void Execute(List<FontRegion> fonts)
        {
            var node = twRegions.Nodes.Find("Nodo3", true).FirstOrDefault() as TreeNode;

            _fonts.AddRange(fonts);

            foreach (var item in fonts)
            {
                node.Nodes.Add(item.Name);
            }
        }

        #region Private Methods

        private string GetValueImage()
        {
            var imageBmp = _getCropImageUseCase.Execute(new GetCropImageUseCaseRequest { Source = new Bitmap(_formImage.pbImagen.Image), Section = new Rectangle(_locRegion.X, _locRegion.Y, _locRegion.Width, _locRegion.Height) }).Image;
            return _getHashImageUseCase.Execute(new GetHashImageUseCaseRequest { Image = CaptureWindowsHelper.BinaryImage(imageBmp, 130) }).Hash;
        }

        public string GetHashFont(Bitmap bmpSource, bool substring = false)
        {
            List<bool> lResult = new List<bool>();
            var textHash = string.Empty;
            var texto = string.Empty;

            Bitmap bmpMin = new Bitmap(bmpSource, new Size(_locRegion.Width, _locRegion.Height));
            for (int j = 0; j < bmpMin.Width; j++)
            {
                for (int i = 0; i < bmpMin.Height; i++)
                {
                    //reduce colors to true / false                
                    lResult.Add(bmpMin.GetPixel(j, i).GetBrightness() < 0.99f);
                }
            }

            foreach (var item in lResult)
            {
                if (item)
                    textHash += "0";
                else
                    textHash += "1";
            }

            if (substring)
            {
                for (int i = 0; i < lResult.Count / 24; i++)
                {
                    if (!textHash.Substring(0, 24).Contains('1'))
                    {
                        textHash = textHash.Substring(24);
                    }
                    else
                    {
                        texto += textHash.Substring(0, 24);
                        textHash = textHash.Substring(24);
                    }
                }
            }
            else
            {
                texto = textHash;
            }

            return texto;
        }

        private static int GetSuitHand(string texto)
        {
            var suit = texto[1] switch
            {
                'c' => 1,
                'h' => 2,
                'd' => 3,
                's' => 4,
                _ => 0
            };

            return suit;
        }

        private static int GetForceHand(string texto)
        {
            var force = texto[0] switch
            {
                'A' => 14,
                'K' => 13,
                'Q' => 12,
                'J' => 11,
                'T' => 10,
                '9' => 9,
                '8' => 8,
                '7' => 7,
                '6' => 6,
                '5' => 5,
                '4' => 4,
                '3' => 3,
                '2' => 2,
                _ => 0
            };

            return force;
        }

        #endregion

        private void cbTest_CheckedChanged(object sender, EventArgs e)
        {
            gbTest.Enabled = cbTest.Checked;
        }

        #region Salir TextBox
        private void tbWidth_Leave(object sender, EventArgs e)
        {
            _formImage.pbImagen.Refresh();

            _papel = _formImage.pbImagen.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);

            _locRegion.Width = int.Parse(tbWidth.Text);
            _papel.DrawRectangle(lapiz, _locRegion.X, _locRegion.Y, _locRegion.Width, _locRegion.Height);

            _img = _formImage.pbImagen.Image;
        }

        private void tbHeight_Leave(object sender, EventArgs e)
        {
            _formImage.pbImagen.Refresh();

            _papel = _formImage.pbImagen.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);

            _locRegion.Width = int.Parse(tbWidth.Text);
            _papel.DrawRectangle(lapiz, _locRegion.X, _locRegion.Y, _locRegion.Width, _locRegion.Height);

            _img = _formImage.pbImagen.Image;

        }

        private void tbX_Leave(object sender, EventArgs e)
        {
            _formImage.pbImagen.Refresh();

            _papel = _formImage.pbImagen.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);

            _locRegion.X = int.Parse(tbX.Text);
            _papel.DrawRectangle(lapiz, _locRegion.X, _locRegion.Y, _locRegion.Width, _locRegion.Height);

            _img = _formImage.pbImagen.Image;
            lbXY.Text = $"X: {_locRegion.X} Y:{_locRegion.Y}";
        }

        private void tbY_Leave(object sender, EventArgs e)
        {
            _formImage.pbImagen.Refresh();

            _papel = _formImage.pbImagen.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);

            _locRegion.Y = int.Parse(tbY.Text);
            _papel.DrawRectangle(lapiz, _locRegion.X, _locRegion.Y, _locRegion.Width, _locRegion.Height);

            _img = _formImage.pbImagen.Image;
            lbXY.Text = $"X: {_locRegion.X} Y:{_locRegion.Y}";
        }

        #endregion
    }
}
