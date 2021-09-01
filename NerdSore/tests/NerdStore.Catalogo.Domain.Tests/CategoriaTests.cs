using NerdScore.Catalogo.Domain;
using NerdScore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class CategoriaTests
    {

        [Fact]

        public void Validar_Categoria_DeveRetornarExecption()
        {

            var ex = Assert.Throws<DomainException>(() => new Categoria("Camisetas", 0));
            Assert.Equal("O campo Codigo não pode ser 0", ex.Message);

            ex = Assert.Throws<DomainException>(() => new Categoria(string.Empty, 1));
            Assert.Equal("O campo Nome da categoria não pode estar vazio", ex.Message);

        }
    }
}
