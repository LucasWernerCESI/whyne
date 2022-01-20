using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public Database Database { get; set; };
    public ItemEntities Entities { get; set; };

    //

    public Database()
    {
        Entities = new ItemEntities();
    }

    //GetItem
    public List<Model.Item>().GetItem()
    {
        var item = Database.Entities.item.Tolist();
        var itemList = new List<Model.Item>;
    }
    public List<Model.ItemV2>().GetItemV2()
    {
        var result = new List<Model.ItemV2>();
        Database.Entities.Item.Select(i => new Model.Client
        {
            name = i.name,
            description = i.Description,
            degreeAlcoolo = i.DegreeAlcoolo,
            familly = i.Familly,
            quantity = i.Quantity,
            provider = i.Provider,
            price = i.Price
        }).Tolist();
    }

    //GetClient
    public List<Model.Client>().GetClient()
    {
        var client = Database.Entities.client.ToList();
        var clientList = new List<Model.Client>;
    }

    //GetProvider
    public List<Model.Provider>().GetProvider()
    {
        var provider = Datababase.Entities.provider.Tolist();
        var providerList = new List<Model.Provider>;
    }

    //GetEveryFamilly
    public List<Model.Item>GetEveryFamilly()
    {
        var familly = Database
            .Entities
            .item
            .Select(x => familly)
            .Distinct()
            .Tolist();
    }

    //GetEveryProvider
    public List<Model.Item> GetEveryProvider()
    {
        var Provider = Database
            .Entities
            .item
            .Select(p => Provider)
            .Distinct()
            .Tolist();
    }


    //Orderby degreeAlcoolo +>-
    public List<Model.Item> OrderByDegree()
    {
        var OrderbyDegree = Database
            .Entities
            .item
            .OrderbyDescending(d => d.degreeAlcoolo)
            .Select(d => new Model.Item {
                name = d.name,
                description = d.Description,
                degreeAlcoolo = d.DegreeAlcoolo,
                familly = d.Familly,
                quantity = d.Quantity,
                provider = d.Provider,
                price = d.Price
            })
            .Tolist();
    }

    //Orderby degreeAlcoolo ->+
    public List<Model.Item> OrderByDegree()
    {
        var OrderbyDegree = Database
            .Entities
            .item
            .OrderbyAscending(d => d.degreeAlcoolo)
            .Select(d => new Model.Item
            {
                name = d.name,
                description = d.Description,
                degreeAlcoolo = d.DegreeAlcoolo,
                familly = d.Familly,
                quantity = d.Quantity,
                provider = d.Provider,
                price = d.Price
            })
            .Tolist();
    }

    //ReturnMostDegree
    public List<Model.Item>OrderByDegree()
    {
        return Database
            .Entities
            .item
            .OrderbyDescending(d =>degreeAlcoolo)
            .Select(d => new Model.Item
            {
                name = d.name,
                description = d.Description,
                degreeAlcoolo = d.DegreeAlcoolo,
                familly = d.Familly,
                quantity = d.Quantity,
                provider = d.Provider,
                price = d.Price
            })
            .First();
    }

    //totallement faux
        public List<Model.Item>AddItem()
        {
            Database
                .Entities
                .Item
                .Add(i => new Model.Item
                {
                    name = i.name,
                    description = i.Description,
                    degreeAlcoolo = i.DegreeAlcoolo,
                    familly = i.Familly,
                    quantity = i.Quantity,
                    provider = i.Provider,
                    price = i.Price
                })
                .Savechange();
    }
}

