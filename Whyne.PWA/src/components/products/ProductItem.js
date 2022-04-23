export default function Product (item) {
  const { ItemId, Icon, Title, Description, DegreeAlcoolo, Familly, Quantity, Provider, Price } = item

  let carts = []

  let Button
  if (Quantity > 0) {
    Button = <button onClick={() => carts((id) => id.concat({ ItemId }))}>Ajouter</button>
  } else {
    Button = <button disabled data-item-id={ItemId}>Précommander</button>
  }

  return (

      <div className="grid-item">
        <img
          src={Icon}
          alt={`Image of ${Title}`}
          className='image-product'
        />
        <h4>{Title}</h4>
        <p>
          Descriptif : {Description}<br />
          Producteur : {Provider} ; ° : {DegreeAlcoolo}<br />
          <br />
          Prix: {Price}<br />
          <br />
          {Button}
        </p>
      </div>

  )
};
