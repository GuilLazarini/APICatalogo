using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Produtos(ProdutoId, Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
           "Values('95feb52e-e30a-41a5-a9f8-025c47ddb880','Coca-Cola Diet','Refrigerante de Cola 350 ml',5.45,'cocacola.jpg',50,now(),'15af1066-ce92-4206-8b94-11c2cde40856')");

            migrationBuilder.Sql("Insert into Produtos(ProdutoId, Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "Values('83949709-56e0-49ea-aad2-d5d65bbf7eb6','Lanche de Atum','Lanche de Atum com maionese',8.50,'atum.jpg',10,now(),'81188c80-a343-40ab-bbdd-d5c1da854b35')");

            migrationBuilder.Sql("Insert into Produtos(ProdutoId, Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
               "Values('6478d8af-5ad5-45d8-9b09-554ddf0f1eca','Pudim 100 g','Pudim de leite condensado 100g',6.75,'pudim.jpg',20,now(),'cfd66208-577e-4ec0-a6ce-66bc65b1de37')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}
