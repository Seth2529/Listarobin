Dependente dep1 = new Dependente("Maria", "Filha");
Dependente dep2 = new Dependente("José", "Filho");
Dependente dep3 = new Dependente("João", "Pai");

Funcionario func1 = new Funcionario("Ana", 3000);
func1.AdicionarDependente(dep1);
func1.AdicionarDependente(dep2);

Funcionario func2 = new Funcionario("Bruno", 4000);
func2.AdicionarDependente(dep3);

Controle ctrl = new Controle();
ctrl.AdicionarFuncionario(func1);
ctrl.AdicionarFuncionario(func2);

ctrl.MostrarTodosDependentes();
