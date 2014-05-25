using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TrollAvi.Resources;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.IO.IsolatedStorage;
using System.IO;

namespace TrollAvi
{
    public partial class MainPage : PhoneApplicationPage
    {
        //http://www.omereryilmaz.com/ 
        // Constructor
        int kontrol=0;
        String[] resimidDizi = new String[2];
       
         
        Image img1 = new Image();
        Image img2 = new Image();
        Image img3 = new Image();
        Image img4 = new Image();
        Image img5 = new Image();
        Image img6 = new Image();
        Image img7 = new Image();
        Image img8 = new Image();
        Image img9 = new Image();
        Image img10 = new Image();
        Image img11 = new Image();
        Image img12 = new Image();
        Image img13 = new Image();
        Image img14 = new Image();
        Image img15 = new Image();
        Image img16 = new Image();
        int butonTiklandi = 0;
        int saniye = 60;
        int sa = 1;
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer resimtimer = new DispatcherTimer();
        DispatcherTimer gostertimer = new DispatcherTimer();

        int acilanCift = 0;
       
        public MainPage()
        {
            InitializeComponent();
             
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
			butonOlustur();
			
			puanGetir();

            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (s, e) =>
            {
                saniye = saniye - 1;
                sureTxt.Text = saniye.ToString();
                if (saniye == 0)
                {
                    timer.Stop();
                    bittiTxt.Text = "Süreniz Bitti!";
                    bittiTxt.Visibility = Visibility.Visible;
                    sureRecBitti.Visibility = Visibility.Visible;
                    YCStoryboard.Begin();
                }
            };
            
            
        }

        private IsolatedStorageSettings Kullanici;
        private void puanGetir()
        {

            Kullanici = IsolatedStorageSettings.ApplicationSettings;
            if (Kullanici.Contains("puan"))
            {
                
                enyuksekTxt.Text = Kullanici["puan"].ToString();
            }

           
        }

        

        private void butonOlustur()
        {

            var dizi = new HashSet<int>(); //aynı elemanın birden fazla eklenmemesi ve eklenenlerin sadece int tipinde
            var rnd = new Random();

            while (dizi.Count != 16) //eleman sayısı 16 olana kadar ekle
            {
                dizi.Add(rnd.Next(1, 17)); //1 - 17 arası sayı üret ve diziye ekle
            }


           

            //butonların oluşturulması

            Button btn1 = new Button();
            btn1.Style = this.Resources["ButtonStyleSon"] as Style; //buton stilinin butona aktarılması
            btn1.Width = 100;
            btn1.Height = 100;
            //btn1.Content = dizi.ElementAt(0).ToString();
            
            btn1.Click += new RoutedEventHandler(btnClick_Click); //tıklandığında ne yapılması isteniyorsa
            btn1.Tag = dizi.ElementAt(0);         // tag ına diziye rastgele atılmış sayılardan 0ncı elemanını at
            h01.Children.Add(btn1);                 //1 nolu hücreye bu butonu yerleştir

           //bu sayede hücrelerde aynı butonlar oluşturuluyor ama tag ları rastgele geliyor
           //gelen rastgele tag lara görede resim getireceğiz

            Button btn2 = new Button();
            btn2.Style = this.Resources["ButtonStyleSon"] as Style;
            btn2.Width = 100;
            btn2.Height = 100;
            //btn2.Content = dizi.ElementAt(1).ToString(); 
            btn2.Tag = dizi.ElementAt(1);
            btn2.Click += new RoutedEventHandler(btnClick_Click);
            h02.Children.Add(btn2);

            Button btn3 = new Button();
            btn3.Style = this.Resources["ButtonStyleSon"] as Style;
            btn3.Width = 100;
            btn3.Height = 100;
            //btn3.Content = dizi.ElementAt(2).ToString();
           
            btn3.Tag = dizi.ElementAt(2);
            btn3.Click += new RoutedEventHandler(btnClick_Click);
            h03.Children.Add(btn3);

            Button btn4 = new Button();
            btn4.Style = this.Resources["ButtonStyleSon"] as Style;
            btn4.Width = 100;
            btn4.Height = 100;
            btn4.Content = dizi.ElementAt(3).ToString();
            btn4.Tag = dizi.ElementAt(3);
            btn4.Click += new RoutedEventHandler(btnClick_Click);
            h04.Children.Add(btn4);

            Button btn5 = new Button();
            btn5.Style = this.Resources["ButtonStyleSon"] as Style;
            btn5.Width = 100;
            btn5.Height = 100;
            btn5.Content = dizi.ElementAt(4).ToString();
            btn5.Tag = dizi.ElementAt(4);
            btn5.Click += new RoutedEventHandler(btnClick_Click);
            h05.Children.Add(btn5);

            Button btn6 = new Button();
            btn6.Style = this.Resources["ButtonStyleSon"] as Style;
            btn6.Width = 100;
            btn6.Height = 100;
            btn6.Content = dizi.ElementAt(5).ToString();
            btn6.Tag = dizi.ElementAt(5);
            btn6.Click += new RoutedEventHandler(btnClick_Click);
            h06.Children.Add(btn6);

            Button btn7 = new Button();
            btn7.Style = this.Resources["ButtonStyleSon"] as Style;
            btn7.Width = 100;
            btn7.Height = 100;
            btn7.Content = dizi.ElementAt(6).ToString();
            btn7.Tag = dizi.ElementAt(6);
            btn7.Click += new RoutedEventHandler(btnClick_Click);
            h07.Children.Add(btn7);

            Button btn8 = new Button();
            btn8.Style = this.Resources["ButtonStyleSon"] as Style;
            btn8.Width = 100;
            btn8.Height = 100;
            btn8.Content = dizi.ElementAt(7).ToString();
            btn8.Tag = dizi.ElementAt(7);
            btn8.Click += new RoutedEventHandler(btnClick_Click);
            h08.Children.Add(btn8);

            Button btn9 = new Button();
            btn9.Style = this.Resources["ButtonStyleSon"] as Style;
            btn9.Width = 100;
            btn9.Height = 100;
            
            btn9.Tag = dizi.ElementAt(8);
            btn9.Click += new RoutedEventHandler(btnClick_Click);
            h09.Children.Add(btn9);

            Button btn10 = new Button();
            btn10.Style = this.Resources["ButtonStyleSon"] as Style;
            btn10.Width = 100;
            btn10.Height = 100;
            btn10.Tag = dizi.ElementAt(9);
            btn10.Click += new RoutedEventHandler(btnClick_Click);
            h10.Children.Add(btn10);

            Button btn11 = new Button();
            btn11.Style = this.Resources["ButtonStyleSon"] as Style;
            btn11.Width = 100;
            btn11.Height = 100;
            btn11.Content = dizi.ElementAt(8).ToString();
            btn11.Tag = dizi.ElementAt(10);
            btn11.Click += new RoutedEventHandler(btnClick_Click);
            h11.Children.Add(btn11);

            Button btn12 = new Button();
            btn12.Style = this.Resources["ButtonStyleSon"] as Style;
            btn12.Width = 100;
            btn12.Height = 100;            
            btn12.Tag = dizi.ElementAt(11);
            btn12.Click += new RoutedEventHandler(btnClick_Click);
            h12.Children.Add(btn12);

            Button btn13 = new Button();
            btn13.Style = this.Resources["ButtonStyleSon"] as Style;
            btn13.Width = 100;
            btn13.Height = 100;            
            btn13.Tag = dizi.ElementAt(12);
            btn13.Click += new RoutedEventHandler(btnClick_Click);
            h13.Children.Add(btn13);

            Button btn14 = new Button();
            btn14.Style = this.Resources["ButtonStyleSon"] as Style;
            btn14.Width = 100;
            btn14.Height = 100;            
            btn14.Tag = dizi.ElementAt(13);
            btn14.Click += new RoutedEventHandler(btnClick_Click);
            h14.Children.Add(btn14);

            Button btn15 = new Button();
            btn15.Style = this.Resources["ButtonStyleSon"] as Style;
            btn15.Width = 100;
            btn15.Height = 100;
            btn15.Tag = dizi.ElementAt(14);
            btn15.Click += new RoutedEventHandler(btnClick_Click);
            h15.Children.Add(btn15);

            Button btn16 = new Button();
            btn16.Style = this.Resources["ButtonStyleSon"] as Style;
            btn16.Width = 100;
            btn16.Height = 100;
            btn16.Tag = dizi.ElementAt(15);
            btn16.Click += new RoutedEventHandler(btnClick_Click);

            h16.Children.Add(btn16);

            //oyunun başında gösterilen kızgın troll resimlerinin oluşturulması
            Image img1x = new Image();
            img1x.Source = new BitmapImage(new Uri("troller/kizgintroll.png", UriKind.RelativeOrAbsolute));
            img1x.Height = 100;
            img1x.Width = 100;

            Image img2x = new Image();
            img2x.Source = new BitmapImage(new Uri("troller/kizgintroll.png", UriKind.RelativeOrAbsolute));
            img2x.Height = 100;
            img2x.Width = 100;
            int[] hangiGrid = new int[2];


           //kizgin trolleri göster
            Grid btngr1 = btn1.Parent as Grid; //btn1 in bulunduğu grid i öğreniyoruz
            //sanırım buradaki butonun bulunduğu grid i öğrenmek gereksiz olmuş sonra düzelitilecek
            
                if (btn1.Tag.ToString() == "5" ) //btn1 butonun tagı 5 ise
                {
                    btngr1.Children.Add(img1x); //btn1 in bulunduğu gride resmi ekle
                    hangiGrid[0] = 1; //hangi gride koydumuzu diziye atıyoruz ki kontrolünü yapabilelim. bu griddeki butona tıklarsa yanacak
                }
                else if(btn1.Tag.ToString() == "16")
                {
                    btngr1.Children.Add(img2x);
                    hangiGrid[1] = 1;
                }
                
        

            Grid btngr2 = btn2.Parent as Grid;

            if (btn2.Tag.ToString() == "5" )
            {
                btngr2.Children.Add(img1x);
                hangiGrid[0] = 2;
            }
            else if (btn2.Tag.ToString() == "16")
            {
                btngr2.Children.Add(img2x);
                hangiGrid[1] = 2;
            }


            Grid btngr3 = btn3.Parent as Grid;
            if (btn3.Tag.ToString() == "5")
            {
                btngr3.Children.Add(img1x);
                hangiGrid[0] = 3;
            }
            else if (btn3.Tag.ToString() == "16")
            {
                btngr3.Children.Add(img2x);
                hangiGrid[1] = 3;
            }

            Grid btngr4 = btn4.Parent as Grid;

            if (btn4.Tag.ToString() == "5" )
            {
                btngr4.Children.Add(img1x);
                hangiGrid[0] = 4;
            }
            else if (btn4.Tag.ToString() == "16")
            {
                btngr4.Children.Add(img2x);
                hangiGrid[1] = 4;
            }

            Grid btngr5 = btn5.Parent as Grid;
            if (btn5.Tag.ToString() == "5" )
            {
                btngr5.Children.Add(img1x);
                hangiGrid[0] = 5;
            }
            else if (btn5.Tag.ToString() == "16")
            {
                btngr5.Children.Add(img2x);
                hangiGrid[1] = 5;
            }

            Grid btngr6 = btn6.Parent as Grid;
            if (btn6.Tag.ToString() == "5" )
            {
                btngr6.Children.Add(img1x);
                hangiGrid[0] = 6;
            }
            else if (btn6.Tag.ToString() == "16")
            {
                btngr6.Children.Add(img2x);
                hangiGrid[1] = 6;
            }

            Grid btngr7 = btn7.Parent as Grid;
            if (btn7.Tag.ToString() == "5" )
            {
                btngr7.Children.Add(img1x);
                hangiGrid[0] = 7;
            }
            else if (btn7.Tag.ToString() == "16")
            {
                btngr7.Children.Add(img2x);
                hangiGrid[1] = 7;
            }

            Grid btngr8 = btn8.Parent as Grid;
            if (btn8.Tag.ToString() == "5")
            {
                btngr8.Children.Add(img1x);
                hangiGrid[0] = 8;
            }
            else if (btn8.Tag.ToString() == "16")
            {
                btngr8.Children.Add(img2x);
                hangiGrid[1] = 8;
            }

            Grid btngr9 = btn9.Parent as Grid;
            if (btn9.Tag.ToString() == "5")
            {
                btngr9.Children.Add(img1x);
                hangiGrid[0] = 9;
            }
            else if (btn9.Tag.ToString() == "16")
            {
                btngr9.Children.Add(img2x);
                hangiGrid[1] = 9;
            }

            Grid btngr10 = btn10.Parent as Grid;
            if (btn10.Tag.ToString() == "5")
            {
                btngr10.Children.Add(img1x);
                hangiGrid[0] = 10;
            }
            else if (btn10.Tag.ToString() == "16")
            {
                btngr10.Children.Add(img2x);
                hangiGrid[1] = 10;
            }

            Grid btngr11 = btn11.Parent as Grid;
            if (btn11.Tag.ToString() == "5")
            {
                btngr11.Children.Add(img1x);
                hangiGrid[0] = 11;
            }
            else if (btn11.Tag.ToString() == "16")
            {
                btngr11.Children.Add(img2x);
                hangiGrid[1] = 11;
            }

            Grid btngr12 = btn12.Parent as Grid;
            if (btn12.Tag.ToString() == "5")
            {
                btngr12.Children.Add(img1x);
                hangiGrid[0] = 12;
            }
            else if (btn12.Tag.ToString() == "16")
            {
                btngr12.Children.Add(img2x);
                hangiGrid[1] = 12;
            }

            Grid btngr13 = btn13.Parent as Grid;
            if (btn13.Tag.ToString() == "5")
            {
                btngr13.Children.Add(img1x);
                hangiGrid[0] = 13;
            }
            else if (btn13.Tag.ToString() == "16")
            {
                btngr13.Children.Add(img2x);
                hangiGrid[1] = 13;
            }

            Grid btngr14 = btn14.Parent as Grid;
            if (btn14.Tag.ToString() == "5")
            {
                btngr14.Children.Add(img1x);
                hangiGrid[0] = 14;
            }
            else if (btn14.Tag.ToString() == "16")
            {
                btngr14.Children.Add(img2x);
                hangiGrid[1] = 14;
            }

            Grid btngr15 = btn15.Parent as Grid;
            if (btn15.Tag.ToString() == "5")
            {
                btngr15.Children.Add(img1x);
                hangiGrid[0] = 15;
            }
            else if (btn15.Tag.ToString() == "16")
            {
                btngr15.Children.Add(img2x);
                hangiGrid[1] = 15;
            }

            Grid btngr16 = btn16.Parent as Grid;
            if (btn16.Tag.ToString() == "5")
            {
                btngr16.Children.Add(img1x);
                hangiGrid[0] = 16;
            }
            else if (btn16.Tag.ToString() == "16")
            {
                btngr16.Children.Add(img2x);
                hangiGrid[1] = 16;
            }

            //grid isimlerini bir diziye atıyoruz
            Grid[] gridisim = {btngr1,btngr2,btngr3,btngr4,btngr5,btngr6,btngr7,btngr8,btngr9,btngr10,btngr11,btngr12,btngr13,btngr14,btngr15,btngr16  };
            sureRec.Visibility = Visibility.Visible;
            bittiTxt.Visibility = Visibility.Visible;
            sureTxt2.Visibility= Visibility.Visible;
            bittiTxt.Text = "Kızgın trollerin yerini unutma!";

            int gostersure = 3; //kızgın trollerin yerini gösterme süresi
            gostertimer.Start();
            gostertimer.Interval = TimeSpan.FromSeconds(1); //1saniye
            gostertimer.Tick += (s, e) =>
            {
                gostersure = gostersure - 1;
                
                sureTxt2.Text = gostersure.ToString();
                if (gostersure == 0) //süre bittiğinde
                {
                    gostertimer.Stop(); //timerı durdur
                    sureRec.Visibility = Visibility.Collapsed; //
                    bittiTxt.Visibility = Visibility.Collapsed;
                    sureTxt2.Visibility = Visibility.Collapsed;
                    //kizgin trolleri kapat
                    for (int i = 0; i < 16; i++) //teker teker gridleri kontrol edip hangisindeyse resmi siliyoruz / kapatıyoruz
                    {
                        if (hangiGrid[0] == i+1)
                        {
                            gridisim[i].Children.Remove(img1x);
                        }

                        if (hangiGrid[1] == i+1)
                        {
                            gridisim[i].Children.Remove(img2x);
                        }
                    }

                       
                       
                   
                        
                    
                }
            };

        }

        private void btnClick_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            butonTiklandi++;
            if (butonTiklandi == 1) { //ilk buton tıklandığında normal süreyi başlat
                timer.Start();
            }
            
            Button button = sender as Button;//hangi buton tıklanmış

            Grid btngr = button.Parent as Grid;//tıklanılan butonun bulunduğu grid
            String gridname= btngr.Name;//tespit edilen gridin ismini stringe at
            
          

                         
            if (button != null)
            {
                
                switch (button.Tag.ToString())//buton tag ı kontrolü
                {
                    case "1":
                        kontrol = kontrol + 1; //tıklama sayısı
                        resimidDizi[kontrol - 1] = "r11"; //attığımız resimlerin yerlerini diziye atıyoruz ki eşleştirmelerde kontrol etmek için
                        
                        img1.Source = new BitmapImage(new Uri("troller/t1.png", UriKind.RelativeOrAbsolute));
                        img1.Height = 100;
                        img1.Width = 100;
                        
                        btngr.Children.Add(img1);
                        
                        if (kontrol == 2) //ikinci buton tıklandıysa
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible; //sureRec2 yi görünür yap (1 saniyelik) tıklamalar iptal
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1; // 1saniyelik bekleme için

                                if (sa == 0) //1 saniye geçtiğinde
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed; //tıklamalar yine aktif
                                }
                            };
                        }
                        //hresim.Children.Add(img1);
                        break;
                    case "2":
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r21";
                        
                        img2.Source = new BitmapImage(new Uri("troller/t2.png", UriKind.RelativeOrAbsolute));
                        img2.Height = 100;
                        img2.Width = 100;
                        
                        btngr.Children.Add(img2);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;
                    case "3":
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r31";
                        
                        img3.Source = new BitmapImage(new Uri("troller/t3.png", UriKind.RelativeOrAbsolute));
                        img3.Height = 100;
                        img3.Width = 100;
                        
                        btngr.Children.Add(img3);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;
                    case "4":
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r41";
                        
                        img4.Source = new BitmapImage(new Uri("troller/t4.png", UriKind.RelativeOrAbsolute));
                        img4.Height = 100;
                        img4.Width = 100;
                        
                        btngr.Children.Add(img4);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {

                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;
					case "5":
                        
                        img5.Source = new BitmapImage(new Uri("troller/kizgintroll.png", UriKind.RelativeOrAbsolute));
                        img5.Height = 100;
                        img5.Width = 100;
                        timer.Stop();
                        btngr.Children.Add(img5);
                        sureRec2.Visibility = Visibility.Collapsed; 
                               bittiTxt.Text = "Kızgın Trolle yakalandınız!";
                               bittiTxt.Visibility = Visibility.Visible;
                               sureRec.Visibility = Visibility.Visible;
                               YCStoryboard.Begin();
                        
                      
                        
                        break;

					case "6":
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r12";
						
                        img6.Source = new BitmapImage(new Uri("troller/t1.png", UriKind.RelativeOrAbsolute));
                        img6.Height = 100;
                        img6.Width = 100;
                        
                        btngr.Children.Add(img6);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;
					case "7": 
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r22";
						
                        img7.Source = new BitmapImage(new Uri("troller/t2.png", UriKind.RelativeOrAbsolute));
                        img7.Height = 100;
                        img7.Width = 100;
                        
                        btngr.Children.Add(img7);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;
					case "8": 
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r32";
                    	
						img8.Source = new BitmapImage(new Uri("troller/t3.png", UriKind.RelativeOrAbsolute));
                        img8.Height = 100;
                        img8.Width = 100;
                       
                        btngr.Children.Add(img8);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;
					case "9": 
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r42";
						
						img9.Source = new BitmapImage(new Uri("troller/t4.png", UriKind.RelativeOrAbsolute));
                        img9.Height = 100;
                        img9.Width = 100;

                        btngr.Children.Add(img9);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;

                    case "10":
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r51";

                        img10.Source = new BitmapImage(new Uri("troller/t5.png", UriKind.RelativeOrAbsolute));
                        img10.Height = 100;
                        img10.Width = 100;

                        btngr.Children.Add(img10);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;

                    case "11":
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r52";

                        img11.Source = new BitmapImage(new Uri("troller/t5.png", UriKind.RelativeOrAbsolute));
                        img11.Height = 100;
                        img11.Width = 100;

                        btngr.Children.Add(img11);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;

                    case "12":
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r61";

                        img12.Source = new BitmapImage(new Uri("troller/t6.png", UriKind.RelativeOrAbsolute));
                        img12.Height = 100;
                        img12.Width = 100;

                        btngr.Children.Add(img12);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;

                    case "13":
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r62";

                        img13.Source = new BitmapImage(new Uri("troller/t6.png", UriKind.RelativeOrAbsolute));
                        img13.Height = 100;
                        img13.Width = 100;

                        btngr.Children.Add(img13);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;

                    case "14":
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r71";

                        img14.Source = new BitmapImage(new Uri("troller/t7.png", UriKind.RelativeOrAbsolute));
                        img14.Height = 100;
                        img14.Width = 100;

                        btngr.Children.Add(img14);
                        
                        if (kontrol == 2)
                        {

                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                        }
                        break;

                    case "15":
                        kontrol = kontrol + 1;
                        resimidDizi[kontrol - 1] = "r72";

                        img15.Source = new BitmapImage(new Uri("troller/t7.png", UriKind.RelativeOrAbsolute));
                        img15.Height = 100;
                        img15.Width = 100;

                        btngr.Children.Add(img15);
                        
                        if (kontrol == 2)
                        {
                            sa = 1;
                            sureRec2.Visibility = Visibility.Visible;
                            resimtimer.Interval = TimeSpan.FromSeconds(1); //resim geciktirme
                            resimtimer.Start();
                            resimtimer.Tick += (s, es) =>
                            {
                                sa = sa - 1;

                                if (sa == 0)
                                {
                                    resimtimer.Stop();
                                    resimKontrol();
                                    sureRec2.Visibility = Visibility.Collapsed;
                                }
                            };
                           
                        }
                    break;

                    case "16":
                       
                    img16.Source = new BitmapImage(new Uri("troller/kizgintroll.png", UriKind.RelativeOrAbsolute));
                        img16.Height = 100;
                        img16.Width = 100;

                    btngr.Children.Add(img16);
                    timer.Stop();
                        sureRec2.Visibility = Visibility.Collapsed;
                                
                               bittiTxt.Text = "Kızgın Trolle yakalandınız!";
                               bittiTxt.Visibility = Visibility.Visible;
                               sureRecBitti.Visibility = Visibility.Visible;
                               YCStoryboard.Begin();
                    
                    break;
                }

                

            }
   
        }

        

        private void resimKontrol()
        {


                      
                    kontrol = 0;
                    
                    Grid img1grid = img1.Parent as Grid;
                    Grid img2grid = img2.Parent as Grid;
                    Grid img3grid = img3.Parent as Grid;
                    Grid img4grid = img4.Parent as Grid;
                    Grid img5grid = img5.Parent as Grid;
                    Grid img6grid = img6.Parent as Grid;
                    Grid img7grid = img7.Parent as Grid;
                    Grid img8grid = img8.Parent as Grid;
                    Grid img9grid = img9.Parent as Grid;
                    Grid img10grid = img10.Parent as Grid;
                    Grid img11grid = img11.Parent as Grid;
                    Grid img12grid = img12.Parent as Grid;
                    Grid img13grid = img13.Parent as Grid;
                    Grid img14grid = img14.Parent as Grid;
                    Grid img15grid = img15.Parent as Grid;
                    Grid img16grid = img16.Parent as Grid;

                    if (resimidDizi[0].Substring(0, 2) != resimidDizi[1].Substring(0, 2)) //açılan 2 resim eşit değilse
                    {
                        
                        //açılan resimleri bul ve kaldır
                        for (int i = 0; i < 2; i++)
                        {
                            switch (resimidDizi[i])
                            {
                                case "r11":
                                    
                                    img1grid.Children.Remove(img1); 
                                    break;
                                case "r21":
                                   
                                    img2grid.Children.Remove(img2);
                                    break;
                                case "r31":
                                    
                                    img3grid.Children.Remove(img3);
                                    break;
                                case "r41":
                                    
                                    img4grid.Children.Remove(img4);
                                    break;
                                //case "kizgin1":
                                //    img5grid.Children.Remove(img5);
                                //    break;

                                //case "kizgin2":
                                //    img16grid.Children.Remove(img16);
                                //    break;
                                case "r12":
                                    
                                    img6grid.Children.Remove(img6);
                                    break;
                                case "r22":
                                    
                                    img7grid.Children.Remove(img7);
                                    break;
                                case "r32":
                                    
                                    img8grid.Children.Remove(img8);
                                    break;
                                case "r42":
                                    
                                    img9grid.Children.Remove(img9);
                                    break;
                                case "r51":
                                    
                                   img10grid.Children.Remove(img10);
                                    break;
                                case "r52":
                                    
                                    img11grid.Children.Remove(img11);
                                    break;
                                case "r61":
                                    
                                    img12grid.Children.Remove(img12);
                                    break;
                                case "r62":
                                    
                                    img13grid.Children.Remove(img13);
                                    break;
                                case "r71":
                                    
                                    img14grid.Children.Remove(img14);
                                    break;
                                case "r72":
                                    
                                    img15grid.Children.Remove(img15);
                                    break;
                            }
                        }

                    }
                    else //açılan 2 resim eşitse
                    {
                        acilanCift++; //açılan çiftleri say
                        if( acilanCift==7) //açılan çift sayısı 7 ye ulaştığında oyun bitmiştir
                        {
                            timer.Stop(); 
                            bittiTxt.Text = "Tebrikler !";
                            int yeniSkor = (60 - Convert.ToInt32(sureTxt.Text)) + 1; //yeni skorurumuzu hesaplıyoruz
                            bittiTxt2.Text = yeniSkor.ToString() + " saniyede tamamladınız.";
							bittiTxt2.Visibility = Visibility.Visible;
                            bittiTxt.Visibility = Visibility.Visible;
                            sureRecBitti.Visibility = Visibility.Visible;
                            YCStoryboard.Begin(); //bitiş animasyonumuzu çağırıyoruz

                            if (enyuksekTxt.Text == "...") //daha önce oynanmamışsa
                            {
                                IsolatedStorageSettings.ApplicationSettings["puan"] = yeniSkor; //puan isimli IsolatedStroge a yeniSkor u atıyoruz
                                IsolatedStorageSettings.ApplicationSettings.Save();
                                enyuksekTxt.Text = yeniSkor.ToString();
                            }
                            else { //daha önceden skor kaydımız varsa
                                 if (yeniSkor > Convert.ToInt32(enyuksekTxt.Text)) //ve skor kaydımız yeniSkor dan düşükse
                                {

                                    IsolatedStorageSettings.ApplicationSettings["puan"] = yeniSkor;
                                    IsolatedStorageSettings.ApplicationSettings.Save();
                                    enyuksekTxt.Text = yeniSkor.ToString();
                                }
                            }
                        }
                    }
            
           
        }

        private void yenidenBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	NavigationService.Navigate(new Uri("/Giris.xaml",UriKind.RelativeOrAbsolute));
        }

        private void cikisBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Application.Current.Terminate(); //oyundan çıkış
        }
        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}