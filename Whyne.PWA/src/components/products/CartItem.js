export default function CartItem (item) {
  const { ItemId, Title, Price } = item // changer le carts ou aller chercher dans db à partir d'id seul

  // fetch('https://localhost:44373/api/Wines')
  //   .then(response => response.json())
  //   .then(data => console.log(data));

  // button onclick à faire
  return (

    <div>
      <p>{Title} {Price} <button data-item-id={ItemId}>Supprimer</button></p>
    </div>
  )
};
