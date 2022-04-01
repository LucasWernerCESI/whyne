export default function Product ( item) {
  const { ItemId, Icon, Title, Description, DegreeAlcoolo, Familly, Quantity, Provider, Price } = item

  const Card = []

  let Button
  if (Quantity > 0) {
    Button = <button onClick={() => Card((id) => id.concat({ ItemId }))}>Ajouter</button>
  } else {
    Button = <button disabled data-item-id={ItemId}>Ajouter</button>
  }

  let S
  const Sc = { Familly }

  if (Sc !== S) {
    S = Sc
    return (
      <>
        <section id={Familly}>
          <h1>{Familly}</h1>
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
        </section>
      </>
    )
  } else {
    return (
      <><img
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
  }

  // return (
  //   <>
  //     <section id={section}>
  //       <h1>{Familly}</h1>
  //       <img
  //         src={Icon}
  //         alt={`Image of ${Title}`}
  //         className='image-product'
  //       />
  //       <h4>{Title}</h4>
  //       <p>
  //         Descriptif : {Description}<br />
  //         Producteur : {Provider} ; ° : {DegreeAlcoolo}<br />
  //         <br />
  //         Prix: {Price}<br />
  //         <br />
  //         {Button}
  //       </p>
  //     </section>
  //   </>
  // )
};
