using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ProximaX.Sirius.Chain.Sdk.Infrastructure.DTO {

    /// <summary>
    /// The account properties type: * 0x01 (1 decimal) - The property type only allows receiving transactions from an address. * 0x02 (2 decimal) - The property type only allows receiving transactions containing a mosaic id. * 0x04 (4 decimal) - The property type only allows sending transactions with a given transaction type. * 0x05 (5 decimal) - Property type sentinel. * 0x81 (129 decimal) - The property type blocks receiving transactions from an address. * 0x82 (130 decimal) - The property type blocks receiving transactions containing a mosaic id. * 0x84 (132 decimal) -  The property type blocks sending transactions with a given transaction type. 
    /// </summary>
    [DataContract]
    public enum AccountPropertyTypeEnum : int
    {
      
    }
}
