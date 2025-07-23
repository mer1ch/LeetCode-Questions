public class Solution {
    public int RomanToInt(string s) {
        string test="";
        int result =0;
        char firstCharacter,secondCharacter;
        var set = new Dictionary<string,int>(){
            {"I",1},
            {"IV",4},
            {"V",5},
            {"IX",9},
            {"X",10},
            {"XL",40},
            {"L",50},
            {"XC",90},
            {"C",100},
            {"D",500},
            {"M",1000},
            {"CD",400},
            {"CM",900}
        };
        for(int i=0;i<s.Length;i++){
            firstCharacter = s[i];
            if((firstCharacter.Equals('I')||firstCharacter.Equals('X')||firstCharacter.Equals('C'))&&i<s.Length-1){
                secondCharacter=s[i+1];
                test=test+firstCharacter+secondCharacter;
                if(set.ContainsKey(test)){
                    result+=set[test];
                    test="";
                    i++;
                    continue;
                }
                test="";
            }
            result+=set[firstCharacter.ToString()];
        }
        return result;
    }
}
