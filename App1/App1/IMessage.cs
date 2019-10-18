using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public interface IMessage
    {
        string run(string Url,string json);

        string bowlingJson(string player1,string player2);


    }
}
