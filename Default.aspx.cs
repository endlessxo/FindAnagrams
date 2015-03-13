using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void find(object sender, EventArgs e)
    {
        //Required for key point #7
        //The list box is cleared prior to adding the anagrams on each request.
        outputList.Items.Clear();
        error_msg.Text = "";
        anagram_count.Text = "";

        //Code below is thanks to Laura Kamfonik's fix as detailed the email Prof. Skinner sent to everybody.
        AnagramHandler(inputString.Text.Replace(' ', (char)0xA0));

        //Required for key point #6
        //The input box is cleared after each post back.
        inputString.Text = "";
    }

    protected void AnagramHandler(string foo)
    {
        //Required for key point #3
        //You must check that the length of the string is between 1 and 8 and if not output the appropriate comment.
        if (inputString.Text.Length > 8 || inputString.Text.Length == 0)
        {
            error_msg.Text = "Please enter a string from 1 to 8 characters!";
        }
        else
        {
            if (duplicate.Checked == false)
            {
                Anagram_With_Duplicates(foo, "");
            }
            else if (duplicate.Checked == true)
            {
                Anagrams_Without_Duplicates(foo, "");
            }
            //Required for key point #4 and #5
            //The count of the number of anagrams found is displayed in the comment label.
            //If the check box is checked then all duplicate anagrams are eliminated and the count reflects this.
            anagram_count.Text = outputList.Items.Count.ToString() + " anagrams found.";
        }
        
    }

    protected void Anagram_With_Duplicates(string s1, string s2)
    {
        if (s1.Length == 0)
        {
            outputList.Items.Add(s2);
        }
        for (int i = 0; i < s1.Length; i++)
        {
            Anagram_With_Duplicates(s1.Substring(0, i - 0) + s1.Substring(i + 1, s1.Length - (i + 1)), s1[i] + s2);
        }
   }

    public bool flag = false;

    //Required for key point #5
    //If the check box is checked then all duplicate anagrams are eliminated and the count reflects this.
    protected void Anagrams_Without_Duplicates(string s1, string s2)
    {
        if (s1.Length == 0)
        {
            for (int i = 0; i < outputList.Items.Count; i++)
            {
                if (s2 == outputList.Items[i].ToString())
                {
                    flag = true;
                }
            }
            if (flag == false)
            {
                outputList.Items.Add(s2);
            }
            flag = false;
        }
        for (int i = 0; i < s1.Length; i++)
        {
            Anagrams_Without_Duplicates(s1.Substring(0, i - 0) + s1.Substring(i + 1, s1.Length - (i + 1)), s1[i] + s2);
        }
  }
}