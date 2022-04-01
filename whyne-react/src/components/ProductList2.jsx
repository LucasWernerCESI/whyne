export default function Product (section, ListItem) {
  // const { ItemId, Icon, Title, Description, DegreeAlcoolo, Familly, Quantity, Provider, Price } = item

  const Card = []
  let Button

  return (
    <>
      <section id={section}>
        {ListItem.array.forEach(element => {
          element.array.forEach(item => {
            if (item.Quantity > 0) {
              // Button = <button onClick={() => Card((id) => id.concat({ item.ItemId }))}>Ajouter</button>
              Button = <button>Ajouter</button>
            } else {
              Button = <button disabled data-item-id={item.ItemId}>Ajouter</button>
            }
            return (
              <>
                <h1>{item.Familly}</h1>
                <img
                  src={item.Icon}
                  alt={`Image of ${item.Title}`}
                  className='image-product'
                />
                <h4>{item.Title}</h4>
                <p>
                  Descriptif: {item.Description}<br />
                  Producteur: {item.Provider}; °: {item.DegreeAlcoolo}<br />
                  <br />
                  Prix: {item.Price}<br />
                  <br />
                  {Button}
                </p>
              </>
            )
          })
        })}
      </section>
    </>
  )
};
