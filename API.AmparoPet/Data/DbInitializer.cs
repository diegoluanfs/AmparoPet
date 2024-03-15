using API.AmparoPet.Models;
using System.Diagnostics;

namespace API.AmparoPet.Data;

public static class DbInitializer
{
    public static void Initialize(AmparoPetContext context)
    {
        var diego = new Carer
        {
            FirstMidName = "Diego",
            LastName = "Silva"
        };

        var luan = new Carer
        {
            FirstMidName = "Luan",
            LastName = "Ferreira"
        };

        var aline = new Carer
        {
            FirstMidName = "Aline",
            LastName = "Amaral"
        };

        var vera = new Carer
        {
            FirstMidName = "Vera",
            LastName = "Silva"
        };

        var cezar = new Carer
        {
            FirstMidName = "Cezar",
            LastName = "Silva"
        };

        var bolinha = new Pet
        {
            PetID = 1050,
            Name = "Liv",
            Caregivers = new List<Carer> { diego, aline }
        };

        var microeconomics = new Pet
        {
            PetID = 4022,
            Name = "Ruiva",
            Caregivers = new List<Carer> { diego, aline }
        };

        var macroeconmics = new Pet
        {
            PetID = 4041,
            Name = "Pônei",
            Caregivers = new List<Carer> { vera }
        };

        var calculus = new Pet
        {
            PetID = 1045,
            Name = "Bolinha",
            Caregivers = new List<Carer> { cezar }
        };

        var trigonometry = new Pet
        {
            PetID = 3141,
            Name = "Pintinha",
            Caregivers = new List<Carer> { vera }
        };

        var composition = new Pet
        {
            PetID = 2021,
            Name = "Alemão",
            Caregivers = new List<Carer> { vera, cezar }
        };

        var sofia = new Pet
        {
            PetID = 2042,
            Name = "Sofia",
            Caregivers = new List<Carer> { vera }
        };

        context.SaveChanges();
    }
}
