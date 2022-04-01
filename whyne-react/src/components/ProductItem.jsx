export default function Product (item) {
  const { ItemId, Icon, Title, Description, DegreeAlcoolo, Familly, Quantity, Provider, Price } = item

  const Card = []

  let Button
  if (Quantity > 0) {
    Button = <button onClick={() => Card((id) => id.concat({ ItemId }))}>Ajouter</button>
  } else {
    Button = <button disabled data-item-id={ItemId}>Ajouter</button>
  }

  return (
    <>
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
    </>
  )
};
