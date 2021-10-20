using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace NsaMobileApp.Behaviors
{
    public class EmailValidationBehavior : Behavior<Entry>
    {
        

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += HandleTextChanged;
            base.OnAttachedTo(bindable);
        }

         void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            //variable that will store the new value in a entry
            var email = e.NewTextValue;

            //email-regex that be will be compared to the users entry
            var emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            //user entered value that will be matched
            var emailEntered = sender as Entry;

            if (Regex.IsMatch(email, emailRegex))
            {
                emailEntered.BackgroundColor = Color.White;
            }
            else
            {
                emailEntered.BackgroundColor = Color.Red;
            }
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= HandleTextChanged;
            base.OnDetachingFrom(bindable);
        }
    }
}
