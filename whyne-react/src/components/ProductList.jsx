export default function Product (Section, ItemList) {
  const { Item } = ItemList

  const Card = []

  let Button
  if (Item.Quantity > 0) {
    Button = <button onClick={() => Card((id) => id.concat({ Item }))}>Ajouter</button>
  } else {
    Button = <button disabled data-item-id={Item.ItemId}>Ajouter</button>
  }

  return (
    <><h2>{Section}</h2>
      <div class='grid-container'>
        <div class='grid-item'>
          <img
            src={Item.Icon}
            alt={`Image of ${Item.Title}`}
            className='image-product'
          />
          <h4>{Item.Title}</h4>
          <p>
            Descriptif : {Item.Description}<br />
            Producteur : {Item.Provider} ; ° : {Item.DegreeAlcoolo}<br />
            <br />
            Prix: {Item.Price}<br />
            <br />
            {Button}
          </p>
        </div>
      </div>
    </>
  )
};
