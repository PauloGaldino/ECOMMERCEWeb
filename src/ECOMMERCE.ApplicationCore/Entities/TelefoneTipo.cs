﻿namespace SGREFRI.ApplicationCore.Entities
{
    public class TelefoneTipo
    {
        public TelefoneTipo()
        {

        }
        public int TelefoneTipoId { get; set; }
        public string Descricao { get; set; }

        public Telefone Telefone { get; set; }

    }
}
