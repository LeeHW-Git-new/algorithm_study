using System;

public class Solution 
{
    public string solution(string[] id_pw, string[,] db) 
    {
        string inputId = id_pw[0];
        string inputPw = id_pw[1];
        
        for (int i = 0; i < db.GetLength(0); i++) 
        {
            string dbId = db[i, 0];
            string dbPw = db[i, 1];

            if (dbId == inputId) 
            {
                return dbPw == inputPw ? "login" : "wrong pw";
            }
        }
        
        return "fail";
    }
}
