export default function ProductItem (item) {
  const { ItemId, Icon, Title, Description, DegreeAlcoolo, Quantity, Provider, Price } = item
  // const { Id, Name, StoredAmount, Supplier, HasBubbles, Color, SugarResidues, Acidity, Alcohol, grapeVariety, Region, Vintage, TFUPrice } = ItemApi

  const carts = []

  let Button
  if (Quantity > 0) {
    Button = <button enabled onClick={carts.concat([item])}>Ajouter</button>
  } else {
    Button = <button disabled data-item-id={ItemId}>Précommander</button>
  }

  return (

    <div className='grid-item'>
      <img
        src={Icon}
        alt={`Image of ${Title}`}
        className='image-product'
      />
      <h4>{Title}</h4>
      <p>
        Descriptif: {Description}<br />
        Producteur: {Provider} ; Degré d'Alcool: {DegreeAlcoolo}<br />
        <br />
        Prix: {Price}<br />
        <br />
        {Button}
      </p>
    </div>

  )
};

// return (

//   <div className='grid-item'>
//     {/* <img
//       src={Icon}
//       alt={`Image of ${Title}`}
//       className='image-product'
//     /> */}
//     <h4>{Name}</h4>
//     <p>
//       Pétillant: {HasBubbles}<br />
//       Couleur: {Color}<br />
//       Résidut de sucre: {SugarResidues}<br />
//       Acidité: {Acidity}<br />
//       Degré d'Alcool: {Alcohol}<br />
//       Variété du fruit: {grapeVariety}<br />
//       Région: {Region}<br />
//       Âge: { Vintage}<br />
//       <br />
//       <br />
//       Prix: {TFUPrice}<br />
//       <br />
//       {Button}
//     </p>
//   </div>

// )
// };
