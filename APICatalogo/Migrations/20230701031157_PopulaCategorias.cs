using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaId, Nome, ImagemUrl) VALUES ('15af1066-ce92-4206-8b94-11c2cde40856', 'Bebida', 'bebidas.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaId, Nome, ImagemUrl) VALUES ('81188c80-a343-40ab-bbdd-d5c1da854b35', 'Lanches', 'lanches.jpg')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaId, Nome, ImagemUrl) VALUES ('cfd66208-577e-4ec0-a6ce-66bc65b1de37', 'Sobremesas', 'sobremesas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categaorias");
        }
    }
}
