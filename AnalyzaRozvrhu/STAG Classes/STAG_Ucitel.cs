﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnalyzaRozvrhu.STAG_Classes
{
    /// <summary>
    /// Třída pro Ucitele (pracovnika) podle STAG
    /// </summary>
    public class Ucitel
    {

        public int referenceCount = 0;

        [JsonProperty("ucitIdno")]
        public int UcitIdno { get; set; }

        [JsonProperty("katedra")]
        public string Katedra { get; set; }

        
        /// <summary>
        /// Obsahuje NULL nebo další pracoviště oddělené , (oddělovačem si nejsem jistý)
        /// </summary>
        [JsonProperty("pracovisteDalsi")]
        public object PracovisteDalsi { get; set; }


        // Informace pro Fandu
        [JsonProperty("jmeno")]
        public string Jmeno { get; set; }

        [JsonProperty("prijmeni")]
        public string Prijmeni { get; set; }

        [JsonProperty("titulPred")]
        public string TitulPred { get; set; }

        [JsonProperty("titulZa")]
        public string TitulZa { get; set; }

    }

}