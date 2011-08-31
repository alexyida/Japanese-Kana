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

namespace Japanese_Kana
{
    public partial class katakana : PhoneApplicationPage
    {
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

        public katakana()
        {
            InitializeComponent();
            if (App.IsTrial)
            {
                ApplicationTitle.Text = "JAPANESE KANA - TRIAL";
            }
            else
            {
                ApplicationTitle.Text = "JAPANESE KANA";
            }
        }

        private void GestureListener_Hold(object sender, GestureEventArgs e)
        {
            switch ((sender as System.Windows.Shapes.Rectangle).Tag.ToString())
            {
                case "wi":
                    katakanaTextBlock.Text = "ウィ";
                    break;
                case "we":
                    katakanaTextBlock.Text = "ウェ";
                    break;
                case "wo":
                    katakanaTextBlock.Text = "ウォ";
                    break;
                case "she":
                    katakanaTextBlock.Text = "シェ";
                    break;
                case "che":
                    katakanaTextBlock.Text = "チェ";
                    break;
                case "tsa":
                    katakanaTextBlock.Text = "ツァ";
                    break;
                case "tse":
                    katakanaTextBlock.Text = "ツェ";
                    break;
                case "tso":
                    katakanaTextBlock.Text = "ツォ";
                    break;
                case "ti":
                    katakanaTextBlock.Text = "ティ";
                    break;
                case "tu":
                    katakanaTextBlock.Text = "トゥ";
                    break;
                case "fa":
                    katakanaTextBlock.Text = "ファ";
                    break;
                case "fi":
                    katakanaTextBlock.Text = "フィ";
                    break;
                case "fe":
                    katakanaTextBlock.Text = "フェ";
                    break;
                case "fo":
                    katakanaTextBlock.Text = "フォ";
                    break;
                case "je":
                    katakanaTextBlock.Text = "ジェ";
                    break;
                case "di":
                    katakanaTextBlock.Text = "ディ";
                    break;
                case "du":
                    katakanaTextBlock.Text = "ドゥ";
                    break;
                case "dyu":
                    katakanaTextBlock.Text = "デュ";
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
        }

        private void GestureListener_Tap(object sender, GestureEventArgs e)
        {
            PopupWindow.IsOpen = false;
        }
    }
}