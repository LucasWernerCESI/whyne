export default function Product (section, ListItem) {
  // const { ItemId, Icon, Title, Description, DegreeAlcoolo, Familly, Quantity, Provider, Price } = item

  const Card = []
  let Button

  return (
    <>
      <section id={section}>
        {ListItem.array.forEach(element => {
          if (element.Quantity > 0) {
            // Button = <button onClick={() => Card((id) => id.concat({ element.ItemId }))}>Ajouter</button>
            Button = <button>Ajouter</button>
          } else {
            Button = <button disabled data-item-id={element.ItemId}>Ajouter</button>
          }

          return (
            <>
              <h1>{element.Familly}</h1>
              <img
                src={element.Icon}
                alt={`Image of ${element.Title}`}
                className='image-product'
              />
              <h4>{element.Title}</h4>
              <p>
                Descriptif: {element.Description}<br />
                Producteur: {element.Provider}; °: {element.DegreeAlcoolo}<br />
                <br />
                Prix: {element.Price}<br />
                <br />
                {Button}
              </p>
            </>
          )
        })};
      </section>
    </>
  )
};
