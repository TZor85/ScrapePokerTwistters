﻿using ScrapePokerTwisters.App.Domain.Entities.Regions;
using ScrapePokerTwisters.App.Interfaces;
using ScrapePokerTwisters.App.Domain.Entities.Regions;
using ScrapePokerTwisters.App.Aplication.Helpers;

namespace ScrapePokerTwisters.App.Aplication.UseCases.Maps
{
    public class LoadTableMapUseCase : ILoadTableMapUseCase
    {
        public LoadTableMapUseCaseResponse Execute(string secret)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            LoadTableMapUseCaseResponse response = new LoadTableMapUseCaseResponse();

            //theDialog.InitialDirectory = @"C:\Code\ScrapePoker\resources";

            //portatil
            theDialog.InitialDirectory = @"C:\Code\Poker\ScrapePoker\resources";
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {

                if ((myStream = theDialog.OpenFile()) != null)
                {

                    var text = string.Empty;
                    using (StreamReader sr = new StreamReader(myStream))
                    {
                        int counter = 0;

                        while ((text = sr.ReadLine()) != null)
                        {
                            var nodo = string.Empty;
                            var name = string.Empty;
                            Regions region = new Regions();
                            ImageRegion imageRegion = new ImageRegion();

                            var type = text.Split('$')[0].Trim();

                            if (type == "r")
                                nodo = "Nodo0";
                            else if (type == "b")
                                nodo = "Nodo1";
                            else if (type == "i")
                                nodo = "Nodo2";
                            else if (type == "f")
                                nodo = "Nodo3";

                            if (!string.IsNullOrEmpty(nodo))
                            {
                                if (nodo == "Nodo0")
                                {
                                    name = text.Split('$')[1].Split("#")[0].Trim();
                                    var coord = text.Split('#')[1].Trim();

                                    var coordenadas = coord.Split('-');

                                    region.Name = name;
                                    region.X = int.Parse(coordenadas[0].Trim());
                                    region.Y = int.Parse(coordenadas[1].Trim());
                                    region.Width = int.Parse(coordenadas[2].Trim());
                                    region.Height = int.Parse(coordenadas[3].Split("&")[0].Trim());

                                    var pp = text.Split("&");

                                    if (text.Split("&")[1].Trim() == "True")
                                        region.IsHash = true;
                                    else
                                        region.IsHash = false;

                                    if (text.Split("&")[2].Trim() == "True")
                                    {
                                        region.IsColor = true;
                                        region.Color = text.Split("&")[4].Trim();
                                    }
                                    else
                                        region.IsColor = false;

                                    if (text.Split("&")[3].Trim() == "True")
                                    {
                                        region.IsBoard = true;
                                    }
                                    else
                                        region.IsBoard = false;

                                    response.Regions.Add(region);
                                    response.Tree.Add(new KeyValuePair<string, string>(nodo, name));
                                }
                                else if (nodo == "Nodo1")
                                {
                                    name = text.Split('$')[1].Split("-")[0].Trim();
                                    var hashImage = text.Split("-")[1].Trim();
                                    var image = EncrypterHelper.GetImageDecrypted(hashImage, secret);

                                    response.Board.Add(new ImageRegion { Name = name, Image = (Bitmap)image });
                                    response.Tree.Add(new KeyValuePair<string, string>(nodo, name));
                                }
                                else if (nodo == "Nodo2")
                                {
                                    name = text.Split('$')[1].Split("-")[0].Trim();
                                    var force = int.Parse(text.Split("-")[1].Trim());
                                    var suit = int.Parse(text.Split("-")[2].Trim());
                                    var valueImage = text.Split("-")[3].Trim();
                                    var hashImage = text.Split("-")[4].Trim();
                                    var image = EncrypterHelper.GetImageDecrypted(hashImage, secret);

                                    response.Images.Add(new ImageRegion { Name = name, Image = (Bitmap)image, Value = valueImage, Force = force, Suit = suit });
                                    response.Tree.Add(new KeyValuePair<string, string>(nodo, name));
                                }
                                else if (nodo == "Nodo3")
                                {
                                    name = text.Split('$')[1].Split("-")[0].Trim();
                                    var valueFont = text.Split("-")[1].Trim();

                                    response.Fonts.Add(new FontRegion { Name = name, Value = valueFont });
                                    response.Tree.Add(new KeyValuePair<string, string>(nodo, name));
                                }
                            }

                            counter++;
                        }
                    }
                }
            }

            return response;
        }
    }
}
