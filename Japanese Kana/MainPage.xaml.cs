using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System.Windows.Resources;
using System.Windows.Threading;



namespace Japanese_Kana
{
    public partial class MainPage : PhoneApplicationPage
    {
        private SoundEffect sound;

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            if (PopupWindow.IsOpen)
            {
                PopupWindow.IsOpen = false;
                e.Cancel = true;
            }
            else
                base.OnBackKeyPress(e);
        }

        public MainPage()
        {
            InitializeComponent();

            if (App.IsTrial)
            {
                BuyHB.Visibility = System.Windows.Visibility.Visible;
                KanaPivot.Title = "JAPANESE KANA - TRIAL";
            }
            else
            {
                BuyHB.Visibility = System.Windows.Visibility.Collapsed;
                KanaPivot.Title = "JAPANESE KANA";
            }


            // Timer to simulate the XNA game loop (SoundEffect classes are from the XNA Framework)
            DispatcherTimer XnaDispatchTimer = new DispatcherTimer();
            XnaDispatchTimer.Interval = TimeSpan.FromMilliseconds(50);

            // Call FrameworkDispatcher.Update to update the XNA Framework internals.
            XnaDispatchTimer.Tick += delegate { try { FrameworkDispatcher.Update(); } catch { } };

            // Start the DispatchTimer running.
            XnaDispatchTimer.Start();
        }

        private void GestureListener_Hold(object sender, GestureEventArgs e)
        {
            switch ((sender as System.Windows.Shapes.Rectangle).Tag.ToString())
            {

                case "a":
                    hiraganaTextBlock.Text = "あ";
                    katakanaTextBlock.Text = "ア";
                    break;
                case "i":
                    hiraganaTextBlock.Text = "い";
                    katakanaTextBlock.Text = "イ";
                    break;
                case "u":
                    hiraganaTextBlock.Text = "う";
                    katakanaTextBlock.Text = "ウ";
                    break;
                case "e":
                    hiraganaTextBlock.Text = "え";
                    katakanaTextBlock.Text = "エ";
                    break;
                case "o":
                    hiraganaTextBlock.Text = "お";
                    katakanaTextBlock.Text = "オ";
                    break;
                case "ka":
                    hiraganaTextBlock.Text = "か";
                    katakanaTextBlock.Text = "カ";
                    break;
                case "ki":
                    hiraganaTextBlock.Text = "き";
                    katakanaTextBlock.Text = "キ";
                    break;
                case "ku":
                    hiraganaTextBlock.Text = "く";
                    katakanaTextBlock.Text = "ク";
                    break;
                case "ke":
                    hiraganaTextBlock.Text = "け";
                    katakanaTextBlock.Text = "ケ";
                    break;
                case "ko":
                    hiraganaTextBlock.Text = "こ";
                    katakanaTextBlock.Text = "コ";
                    break;
                case "sa":
                    hiraganaTextBlock.Text = "さ";
                    katakanaTextBlock.Text = "サ";
                    break;
                case "shi":
                    hiraganaTextBlock.Text = "し";
                    katakanaTextBlock.Text = "シ";
                    break;
                case "su":
                    hiraganaTextBlock.Text = "す";
                    katakanaTextBlock.Text = "ス";
                    break;
                case "se":
                    hiraganaTextBlock.Text = "せ";
                    katakanaTextBlock.Text = "セ";
                    break;
                case "so":
                    hiraganaTextBlock.Text = "そ";
                    katakanaTextBlock.Text = "ソ";
                    break;
                case "ta":
                    hiraganaTextBlock.Text = "た";
                    katakanaTextBlock.Text = "タ";
                    break;
                case "chi":
                    hiraganaTextBlock.Text = "ち";
                    katakanaTextBlock.Text = "チ";
                    break;
                case "tsu":
                    hiraganaTextBlock.Text = "つ";
                    katakanaTextBlock.Text = "ツ";
                    break;
                case "te":
                    hiraganaTextBlock.Text = "て";
                    katakanaTextBlock.Text = "テ";
                    break;
                case "to":
                    hiraganaTextBlock.Text = "と";
                    katakanaTextBlock.Text = "ト";
                    break;
                case "na":
                    hiraganaTextBlock.Text = "な";
                    katakanaTextBlock.Text = "ナ";
                    break;
                case "ni":
                    hiraganaTextBlock.Text = "に";
                    katakanaTextBlock.Text = "二";
                    break;
                case "nu":
                    hiraganaTextBlock.Text = "ぬ";
                    katakanaTextBlock.Text = "ヌ";
                    break;
                case "ne":
                    hiraganaTextBlock.Text = "ね";
                    katakanaTextBlock.Text = "ネ";
                    break;
                case "no":
                    hiraganaTextBlock.Text = "の";
                    katakanaTextBlock.Text = "ノ";
                    break;
                case "ha":
                    hiraganaTextBlock.Text = "は";
                    katakanaTextBlock.Text = "ハ";
                    break;
                case "hi":
                    hiraganaTextBlock.Text = "ひ";
                    katakanaTextBlock.Text = "ヒ";
                    break;
                case "fu":
                    hiraganaTextBlock.Text = "ふ";
                    katakanaTextBlock.Text = "フ";
                    break;
                case "he":
                    hiraganaTextBlock.Text = "へ";
                    katakanaTextBlock.Text = "ヘ";
                    break;
                case "ho":
                    hiraganaTextBlock.Text = "ほ";
                    katakanaTextBlock.Text = "ホ";
                    break;
                case "ma":
                    hiraganaTextBlock.Text = "ま";
                    katakanaTextBlock.Text = "マ";
                    break;
                case "mi":
                    hiraganaTextBlock.Text = "み";
                    katakanaTextBlock.Text = "ミ";
                    break;
                case "mu":
                    hiraganaTextBlock.Text = "む";
                    katakanaTextBlock.Text = "ム";
                    break;
                case "me":
                    hiraganaTextBlock.Text = "め";
                    katakanaTextBlock.Text = "メ";
                    break;
                case "mo":
                    hiraganaTextBlock.Text = "も";
                    katakanaTextBlock.Text = "モ";
                    break;
                case "ya":
                    hiraganaTextBlock.Text = "や";
                    katakanaTextBlock.Text = "ヤ";
                    break;
                case "yu":
                    hiraganaTextBlock.Text = "ゆ";
                    katakanaTextBlock.Text = "ユ";
                    break;
                case "yo":
                    hiraganaTextBlock.Text = "よ";
                    katakanaTextBlock.Text = "ヨ";
                    break;
                case "ra":
                    hiraganaTextBlock.Text = "ら";
                    katakanaTextBlock.Text = "ラ";
                    break;
                case "ri":
                    hiraganaTextBlock.Text = "り";
                    katakanaTextBlock.Text = "リ";
                    break;
                case "ru":
                    hiraganaTextBlock.Text = "る";
                    katakanaTextBlock.Text = "ル";
                    break;
                case "re":
                    hiraganaTextBlock.Text = "れ";
                    katakanaTextBlock.Text = "レ";
                    break;
                case "ro":
                    hiraganaTextBlock.Text = "ろ";
                    katakanaTextBlock.Text = "ロ";
                    break;
                case "wa":
                    hiraganaTextBlock.Text = "わ";
                    katakanaTextBlock.Text = "ワ";
                    break;
                case "wo":
                    hiraganaTextBlock.Text = "を";
                    katakanaTextBlock.Text = "ヲ";
                    break;
                case "n":
                    hiraganaTextBlock.Text = "ん";
                    katakanaTextBlock.Text = "ン";
                    break;
                case "ga":
                    hiraganaTextBlock.Text = "が";
                    katakanaTextBlock.Text = "ガ";
                    break;
                case "gi":
                    hiraganaTextBlock.Text = "ぎ";
                    katakanaTextBlock.Text = "ギ";
                    break;
                case "gu":
                    hiraganaTextBlock.Text = "ぐ";
                    katakanaTextBlock.Text = "グ";
                    break;
                case "ge":
                    hiraganaTextBlock.Text = "げ";
                    katakanaTextBlock.Text = "ゲ";
                    break;
                case "go":
                    hiraganaTextBlock.Text = "ご";
                    katakanaTextBlock.Text = "ゴ";
                    break;
                case "za":
                    hiraganaTextBlock.Text = "ざ";
                    katakanaTextBlock.Text = "ザ";
                    break;
                case "ji":
                    if ((sender as System.Windows.Shapes.Rectangle).Name.ToString().ToLower() == "di")
                    {
                        hiraganaTextBlock.Text = "ぢ";
                        katakanaTextBlock.Text = "ヂ";
                    }
                    else
                    {
                        hiraganaTextBlock.Text = "じ";
                        katakanaTextBlock.Text = "ジ";
                    }
                    break;
                case "zu":
                    if ((sender as System.Windows.Shapes.Rectangle).Name.ToString().ToLower() == "du")
                    {
                        hiraganaTextBlock.Text = "づ";
                        katakanaTextBlock.Text = "ヅ";
                    }
                    else
                    {
                        hiraganaTextBlock.Text = "ず";
                        katakanaTextBlock.Text = "ズ";
                    }
                    break;
                case "ze":
                    hiraganaTextBlock.Text = "ぜ";
                    katakanaTextBlock.Text = "ゼ";
                    break;
                case "zo":
                    hiraganaTextBlock.Text = "ぞ";
                    katakanaTextBlock.Text = "ゾ";
                    break;
                case "da":
                    hiraganaTextBlock.Text = "だ";
                    katakanaTextBlock.Text = "ダ";
                    break;
                case "de":
                    hiraganaTextBlock.Text = "で";
                    katakanaTextBlock.Text = "デ";
                    break;
                case "do":
                    hiraganaTextBlock.Text = "ど";
                    katakanaTextBlock.Text = "ド";
                    break;
                case "ba":
                    hiraganaTextBlock.Text = "ば";
                    katakanaTextBlock.Text = "バ";
                    break;
                case "bi":
                    hiraganaTextBlock.Text = "び";
                    katakanaTextBlock.Text = "ビ";
                    break;
                case "bu":
                    hiraganaTextBlock.Text = "ぶ";
                    katakanaTextBlock.Text = "ブ";
                    break;
                case "be":
                    hiraganaTextBlock.Text = "べ";
                    katakanaTextBlock.Text = "ベ";
                    break;
                case "bo":
                    hiraganaTextBlock.Text = "ぼ";
                    katakanaTextBlock.Text = "ボ";
                    break;
                case "pa":
                    hiraganaTextBlock.Text = "ぱ";
                    katakanaTextBlock.Text = "パ";
                    break;
                case "pi":
                    hiraganaTextBlock.Text = "ぴ";
                    katakanaTextBlock.Text = "ピ";
                    break;
                case "pu":
                    hiraganaTextBlock.Text = "ぷ";
                    katakanaTextBlock.Text = "プ";
                    break;
                case "pe":
                    hiraganaTextBlock.Text = "ぺ";
                    katakanaTextBlock.Text = "ペ";
                    break;
                case "po":
                    hiraganaTextBlock.Text = "ぽ";
                    katakanaTextBlock.Text = "ポ";
                    break;
                case "kya":
                    hiraganaTextBlock.Text = "きゃ";
                    katakanaTextBlock.Text = "キャ";
                    break;
                case "kyu":
                    hiraganaTextBlock.Text = "きゅ";
                    katakanaTextBlock.Text = "キュ";
                    break;
                case "kyo":
                    hiraganaTextBlock.Text = "きょ";
                    katakanaTextBlock.Text = "キョ";
                    break;
                case "sha":
                    hiraganaTextBlock.Text = "しゃ";
                    katakanaTextBlock.Text = "シャ";
                    break;
                case "shu":
                    hiraganaTextBlock.Text = "しゅ";
                    katakanaTextBlock.Text = "シュ";
                    break;
                case "sho":
                    hiraganaTextBlock.Text = "しょ";
                    katakanaTextBlock.Text = "ショ";
                    break;
                case "cha":
                    hiraganaTextBlock.Text = "ちゃ";
                    katakanaTextBlock.Text = "チャ";
                    break;
                case "chu":
                    hiraganaTextBlock.Text = "ちゅ";
                    katakanaTextBlock.Text = "チュ";
                    break;
                case "cho":
                    hiraganaTextBlock.Text = "ちょ";
                    katakanaTextBlock.Text = "チョ";
                    break;
                case "nya":
                    hiraganaTextBlock.Text = "にゃ";
                    katakanaTextBlock.Text = "ニャ";
                    break;
                case "nyu":
                    hiraganaTextBlock.Text = "にゅ";
                    katakanaTextBlock.Text = "ニュ";
                    break;
                case "nyo":
                    hiraganaTextBlock.Text = "にょ";
                    katakanaTextBlock.Text = "ニョ";
                    break;
                case "hya":
                    hiraganaTextBlock.Text = "ひゃ";
                    katakanaTextBlock.Text = "ヒャ";
                    break;
                case "hyu":
                    hiraganaTextBlock.Text = "ひゅ";
                    katakanaTextBlock.Text = "ヒュ";
                    break;
                case "hyo":
                    hiraganaTextBlock.Text = "ひょ";
                    katakanaTextBlock.Text = "ヒョ";
                    break;
                case "mya":
                    hiraganaTextBlock.Text = "みゃ";
                    katakanaTextBlock.Text = "ミャ";
                    break;
                case "myu":
                    hiraganaTextBlock.Text = "みゅ";
                    katakanaTextBlock.Text = "ミュ";
                    break;
                case "myo":
                    hiraganaTextBlock.Text = "みょ";
                    katakanaTextBlock.Text = "ミョ";
                    break;
                case "rya":
                    hiraganaTextBlock.Text = "りゃ";
                    katakanaTextBlock.Text = "リャ";
                    break;
                case "ryu":
                    hiraganaTextBlock.Text = "りゅ";
                    katakanaTextBlock.Text = "リュ";
                    break;
                case "ryo":
                    hiraganaTextBlock.Text = "りょ";
                    katakanaTextBlock.Text = "リョ";
                    break;
                case "gya":
                    hiraganaTextBlock.Text = "ぎゃ";
                    katakanaTextBlock.Text = "ギャ";
                    break;
                case "gyu":
                    hiraganaTextBlock.Text = "ぎゅ";
                    katakanaTextBlock.Text = "ギュ";
                    break;
                case "gyo":
                    hiraganaTextBlock.Text = "ぎょ";
                    katakanaTextBlock.Text = "ギョ";
                    break;
                case "ja":
                    hiraganaTextBlock.Text = "じゃ";
                    katakanaTextBlock.Text = "ジャ";
                    break;
                case "ju":
                    hiraganaTextBlock.Text = "じゅ";
                    katakanaTextBlock.Text = "ジュ";
                    break;
                case "jo":
                    hiraganaTextBlock.Text = "じょ";
                    katakanaTextBlock.Text = "ジョ";
                    break;
                case "bya":
                    hiraganaTextBlock.Text = "びゃ";
                    katakanaTextBlock.Text = "ビャ";
                    break;
                case "byu":
                    hiraganaTextBlock.Text = "びゅ";
                    katakanaTextBlock.Text = "ビュ";
                    break;
                case "byo":
                    hiraganaTextBlock.Text = "びょ";
                    katakanaTextBlock.Text = "ビョ";
                    break;
                case "pya":
                    hiraganaTextBlock.Text = "ぴゃ";
                    katakanaTextBlock.Text = "ピャ";
                    break;
                case "pyu":
                    hiraganaTextBlock.Text = "ぴゅ";
                    katakanaTextBlock.Text = "ピュ";
                    break;
                case "pyo":
                    hiraganaTextBlock.Text = "ぴょ";
                    katakanaTextBlock.Text = "ピョ";
                    break;
            }
            romajiTextBlock.Text = (sender as System.Windows.Shapes.Rectangle).Tag.ToString();

            PopupWindow.IsOpen = true;
            SlideTransition transition = new SlideTransition();
            transition.Mode = SlideTransitionMode.SlideLeftFadeIn;

            ITransition animation = transition.GetTransition(PopupWindow);
            animation.Completed += delegate
            {
                //PopupWindow.IsOpen = true;
            };
            animation.Begin();

            if (!App.IsTrial)
            {
                LoadSound("Audio/" + (sender as System.Windows.Shapes.Rectangle).Tag.ToString() + ".wav", out sound);
                sound.Play();
            }
        }

        private void GestureListener_Tap(object sender, GestureEventArgs e)
        {
            PopupWindow.IsOpen = false;
        }
        
        /// <summary>
        /// Loads a wav file into an XNA Framework SoundEffect.
        /// </summary>
        /// <param name="SoundFilePath">Relative path to the wav file.</param>
        /// <param name="Sound">The SoundEffect to load the audio into.</param>
        private void LoadSound(String SoundFilePath, out SoundEffect Sound)
        {
            // For error checking, assume we'll fail to load the file.
            Sound = null;

            try
            {
                // Holds informations about a file stream.
                StreamResourceInfo SoundFileInfo = App.GetResourceStream(new Uri(SoundFilePath, UriKind.Relative));

                // Create the SoundEffect from the Stream
                Sound = SoundEffect.FromStream(SoundFileInfo.Stream);
            }
            catch (NullReferenceException)
            {
                // Display an error message
                MessageBox.Show("Couldn't load sound " + SoundFilePath);
            }
        }

        private void appbar_about_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/katakana.xaml", UriKind.Relative));
        }

        private void BuyHB_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Phone.Tasks.MarketplaceDetailTask buy = new Microsoft.Phone.Tasks.MarketplaceDetailTask();
            buy.Show();
        }
    }
}