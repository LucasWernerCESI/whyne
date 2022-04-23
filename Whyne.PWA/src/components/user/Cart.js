import { BrowserRouter as Router, Route, Link, Routes } from "react-router-dom"
import carts from '../products/ProductItem'
import ProductItem from '../products/ProductItem'

export default function Cart({carts}) {
  
    return (     
    <div>
      <Link to="/">⇐ Retour</Link>

      <h2>Votre Panier :</h2>

      {carts.Liste.map((product, i) => <ProductItem {...product} key={i} />)}

    </div> 
  );
}