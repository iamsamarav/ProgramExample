using ProgramExample.Models;

Gerente usuarioG = new Gerente("Paulo", 35, "000.000.000-00", 6500);

Cliente usuarioC = new Cliente(usuarioG);

string nome = usuarioG.GetNome();

usuarioC.GetGerente(nome);

//Manter só o GetNome