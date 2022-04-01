export default function Product (item) {
  const { ItemId, Icon, Title, Description, DegreeAlcoolo, Familly, Quantity, Provider, Price } = item

  return (
    <>
      <a href='#' {...Familly}>{Familly}</a>
    </>
  )
};
