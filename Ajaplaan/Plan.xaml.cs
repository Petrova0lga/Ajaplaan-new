using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Ajaplaan
{
    public partial class Plan : ContentPage
    {
        TimeSpan selctTime;
        public Plan()
        {
            InitializeComponent();
        }

        private void TimePicker_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            selctTime = tpicker.Time;

            if (selctTime.Hours.ToString() == "1")
            {
                img.Source = "sunrise.jpg";
                Lbl.Text = selctTime.ToString();
            }
            else if (selctTime.Hours.ToString() == "2")
            {
                img.Source = "night.jpg";
                Lbl.Text = "Night";

            }
            else if (selctTime.Hours.ToString() == "3")
            {
                img.Source = "dinner.jpg";
                Lbl.Text = "Dinner";

            }
            else if (selctTime.Hours.ToString() == "4")
            {
                img.Source = "dog.jpg";
                Lbl.Text = "Dog walking";

            }
            else if (selctTime.Hours.ToString() == "5")
            {
                img.Source = "cat.jpg";
                Lbl.Text = "Cat time";

            }
            else if (selctTime.Hours.ToString() == "6")
            {
                img.Source = "Coding.jpg";
                Lbl.Text = "Coding time";

            }
            else if (selctTime.Hours.ToString() == "7")
            {
                img.Source = "tea.jpeg";
                Lbl.Text = "Tea drinking time";

            }
            else if (selctTime.Hours.ToString() == "8")
            {
                img.Source = "chill.jpeg";
                Lbl.Text = "Chilling time";

            }
            else if (selctTime.Hours.ToString() == "9")
            {
                img.Source = "reading.jpeg";
                Lbl.Text = "Reading time";

            }
            else if (selctTime.Hours.ToString() == "10")
            {
                img.Source = "dinner.jpg";
                Lbl.Text = "Dinner time";

            }
            else if (selctTime.Hours.ToString() == "11")
            {
                img.Source = "presleep.jpg";
                Lbl.Text = "Pre-sleep time";

            }
            else if (selctTime.Hours.ToString() == "0")
            {
                img.Source = "sleep.jpg";
                Lbl.Text = "Good Night.";

            }
        }
    }
}
