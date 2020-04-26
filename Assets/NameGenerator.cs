using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class NameGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        StringBuilder generatedNames = new StringBuilder();
        int nNames = 10;

        string[][] factionNames = { FACTION_PREFIX, FACTION_SUFFIX, FACTION_TYPES };
        generatedNames.AppendLine("Faction Names:");
        for (int i = 0; i < nNames; i++)
        {
            generatedNames.AppendLine(syllableNameGenerator(random, factionNames));
        }
        generatedNames.AppendLine();

        string[][] starNames = { STAR_PREFIX, STAR_INFIX, STAR_SUFFIX, STAR_DESCRIPTOR };
        generatedNames.AppendLine("Star Names:");
        for (int i = 0; i < nNames; i++)
        {
            generatedNames.AppendLine(syllableNameGenerator(random, starNames));
        }
        generatedNames.AppendLine();

        string[][] oreNames = { ORE_PREFIX, ORE_SUFFIX };
        generatedNames.AppendLine("Ore Names:");
        for (int i = 0; i < nNames; i++)
        {
            generatedNames.AppendLine(syllableNameGenerator(random, oreNames));
        }
        generatedNames.AppendLine();

        string[][] shipNames = { SHIP_PREFIX, SHIP_SUFFIX };
        generatedNames.AppendLine("Ship Names:");
        for (int i = 0; i < nNames; i++)
        {
            generatedNames.AppendLine(syllableNameGenerator(random, shipNames));
        }

        Debug.Log(generatedNames.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string syllableNameGenerator(System.Random random, string[][] syllables)
    {
        StringBuilder name = new StringBuilder();
        for (int index = 0; index < syllables.Length; index++)
        {
            int choice = random.Next(syllables[index].Length);
            string syllable = syllables[index][choice];
            name.Append(syllable);
        }
        return name.ToString();
    }

    static string[] FACTION_PREFIX = new string[]{
            "Ari",
            "Axo",
            "Axi",
            "Be",
            "Ceta",
            "Cira",
            "Ciro",
            "Eno",
            "Equa",
            "Equi",
            "Exo",
            "Fe",
            "Gali",
            "Galy",
            "Gani",
            "Hypo",
            "Iglo",
            "Ixa",
            "Mu",
            "Nano",
            "Neo",
            "Neu",
            "Nexo",
            "Nono",
            "Oca",
            "Oxi",
            "Oxy",
            "Psy",
            "Quo",
            "Tera",
            "Thy",
            "Undi",
            "Uxo",
            "Vea",
            "Vi",
            "Viro",
            "Via",
            "Xena",
            "Xeno",
            "Xeo",
            "Xy",
            "Zena",
            "Zeta"
    };

    static string[] FACTION_SUFFIX = new string[]{
            "con",
            "chon",
            "chron",
            "der",
            "fax",
            "fi",
            "gon",
            "lite",
            "lyte",
            "loi",
            "lon",
            "los",
            "lyx",
            "rax",
            "rani",
            "rano",
            "rea",
            "syn",
            "syth",
            "sino",
            "the",
            "to",
            "tara",
            "tera",
            "tere",
            "tra",
            "tro",
            "var",
            "vax",
            "vea",
            "vyr",
            "vyn",
            "zer",
            "zin",
            "zon"
    };

    static string[] FACTION_TYPES = new string[]{
            " Alliance",
            " Assembly",
            " Association",
            " Coalition",
            " Collective",
            " Commonwealth",
            " Confederacy",
            " Conglomerate",
            " Conspiracy",
            " Corporation",
            " Council",
            " Empire",
            " Federation",
            " Group",
            " Guild",
            " League",
            " Nation",
            " Network",
            " Order",
            " Organization",
            " Republic",
            " State",
            " Union"
    };

    static string[] STAR_PREFIX = new string[]{
            "Aquar",
            "Can",
            "Del",
            "Dom",
            "Drac",
            "Erid",
            "Ign",
            "Lyr",
            "Mag",
            "Or",
            "Ret",
            "Rig",
            "Sin",
            "Sirr",
            "Sol",
            "Stell",
            "Taur",
            "Vel",
            "Ven",
            "Xen"
    };

    static string[] STAR_INFIX = new string[]{
            "an", "ar", "at", "it", "itar", "in", "on", "un"
    };

    static string[] STAR_SUFFIX = new string[]{
            "a", "ae", "as", "ex", "i", "ii", "io", "is", "ias", "ius", "os", "us",
    };

    static string[] STAR_DESCRIPTOR = new string[]{
            " Alpha",
            " Beta",
            " Gamma",
            " Delta",
            " Epsilon",
            " Eta",
            " Iota",
            " Major",
            " Majoris",
            " Maximus",
            " Malus",
            " Minor",
            " Minoris",
            " Minimus",
            " Omega",
            " Prime",
            " Sigma",
            " Zeta",
    };

    static string[] ORE_PREFIX = new string[]{
            "Al",
            "Aux",
            "Bith",
            "Burl",
            "Bar",
            "Cen",
            "Chul",
            "Churr",
            "Cirr",
            "Clar",
            "Coll",
            "Dar",
            "Davn",
            "Dyn",
            "El",
            "Err",
            "Etern",
            "Hex",
            "Hurn",
            "Hyp",
            "Hyz",
            "Ir",
            "Ilt",
            "Ith",
            "Ix",
            "Jal",
            "Jalm",
            "Jav",
            "Jov",
            "Kelv",
            "Kev",
            "Lar",
            "Len",
            "Lox",
            "Maun",
            "Max",
            "Murn",
            "Myth",
            "Nal",
            "Nil",
            "Non",
            "Off",
            "Oft",
            "Olk",
            "Ord",
            "Pax",
            "Parn",
            "Qual",
            "Quan",
            "Quin",
            "Ran",
            "Rar",
            "Rath",
            "Rob",
            "Roz",
            "Sar",
            "Sel",
            "Soph",
            "Soth",
            "Star",
            "Stan",
            "Tath",
            "Tan",
            "Tec",
            "Tech",
            "Tof",
            "Toth",
            "Ul",
            "Ur",
            "Un",
            "Unad",
            "Val",
            "Vaz",
            "Vex",
            "Vox",
            "Xel",
            "Xor",
            "Zan",
            "Zith",
            "Zor"
    };

    static string[] ORE_SUFFIX = new string[]{
            "agen",
            "ine",
            "inite",
            "inium",
            "inum",
            "inyte",
            "ion",
            "ite",
            "ium",
            "ogen",
            "on",
            "onite",
            "onium",
            "onum",
            "onyte",
            "um",
            "ygen",
            "yte"
    };

    static string[] SHIP_PREFIX = new string[]{
            "Dark", "Death", "Ever", "Great", "Heavy", "Hyper", "Infini", "Light", "Ultra"
    };

    static string[] SHIP_SUFFIX = new string[]{
            "blade", "hawk", "seeker", "ship", "spear", "star", "talon", "voyager", "wing"
    };
}
