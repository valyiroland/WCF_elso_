using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_elso_server.Models;


namespace WCF_elso_server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Eloado>  GetEloado();

        [OperationContract]
        string GetEloadoName();


        [OperationContract]
        Zeneszam GetZeneszam();

        [OperationContract]

        Cd GetCd();

        [OperationContract]
        string UjEloado(Eloado eloado);
        [OperationContract]
        string ModositEloado(Eloado eloado);
        [OperationContract]
        string TorolEloado(int id);

        [OperationContract]
        string UjZeneszam(Zeneszam ujZeneszam);
        [OperationContract]
        string ModositZeneszam(Zeneszam zeneszam);
        [OperationContract]
        string TorolZeneszam(int id);





        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.






}
