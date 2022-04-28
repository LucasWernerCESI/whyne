import { BrowserRouter as Router, Route, Link, Routes } from 'react-router-dom'
import carts from '../products/ProductItem'
import CartItem from '../products/CartItem'

// fetch('https://localhost:44373/api/Wines')
//   .then(response => response.json())
//   .then(data => console.log(data));
const FullPrice = 0
// carts.forEach(item => { FullPrice = (FullPrice + item.price) })

console.log(carts)

export default function Cart (carts) {
  return (
    <div>
      <Link to='/'>⇐ Retour</Link>

      <h2>Votre Panier :</h2>
      {carts.Liste.map((product) => <CartItem {...product} />)}
      <br />
      <p>Prix total : {FullPrice}</p><button>Payer</button>

    </div>
  )
}
