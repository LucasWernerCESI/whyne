import { Link } from 'react-router-dom'
// import fetch from 'node-fetch'
import CartItem from '../products/CartItem'

// const GetWines = fetch('https://localhost:44373/api/Wines').then(response => response.json())

const FullPrice = 0
// carts.forEach(item => { FullPrice = (FullPrice + item.price) })

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
