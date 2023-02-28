//Operadores aritmeticos
int adicao = 5 + 3;
int subtracao = 5 - 3;
int multiplicacao = 5 * 3;
int divisao = 15 / 3;

int expr = (1 + 2) * 5 - 2 / 2;

//Operadores relacionais
string cidade1 = "Belo Horizonte";
string cidade2 = "Rio de Janeiro";

bool ret1 = cidade1 == cidade2;
bool ret2 = cidade2 != cidade1;

int i = 2;
int j = 5;

bool ret3 = i == j;
bool ret4 = i != j;
bool ret5 = i > j;
bool ret6 = i < j;
bool ret7 = i >= j;
bool ret8 = i <= j;

//Operadores logicos
bool ret9 = i != j && ret1 == ret2; //false
bool ret10 = i < j && ret1 != ret2; //true

bool ret11 = i > j || ret1 != ret2; //true

bool ret12 = !(i < j);


Console.WriteLine($"{ret12}");