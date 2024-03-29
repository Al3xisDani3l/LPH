﻿using LPH.Core.Interfaces;

namespace LPH.Core.DTOs
{
    public class OrdenCommentDto : IEntity
    {
        public int Id { get; set; }

        public int IdOrden { get; set; }

        public int IdUser { get; set; }

        public float Calificacion { get; set; }

        public string Comentario { get; set; }

    }
}
