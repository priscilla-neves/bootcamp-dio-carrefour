using System; 

class URI {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
            
        //Insira o seu código aqui
        var n = int.Parse(v[0]);
        var l = int.Parse(v[1]);
        
        var p = n * l;
        
        Console.Write(p);
    }

}