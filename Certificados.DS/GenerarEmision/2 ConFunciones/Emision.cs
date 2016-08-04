﻿using Certificados.Negocio.GenerarCertificados;
using System;

namespace Certificados.DS.GenerarEmision.ConFunciones
{
    public class Emision
    {
        public DateTime FechaDeGeneracion { get; internal set; }
        public CertificadoDigital CertificadoDeAutenticacion { get; internal set; }
        public CertificadoDigital CertificadoDeFirma { get; internal set; }
    }
}