import React from 'react'
import Header from './navigation/Header'
import Footer from './navigation/Footer'
import ProductList from './products/ProductList'

  // useEffect(async () => {
  //   const response = await fetch("https://localhost:44373/api/Customers");
  //   const data = await response.json();
  //   console.log(data)
  // })


  // fetch('https://localhost:44373/api/Wines')
  //   .then(response => response.json())
  //   .then(data => console.log(data));


export default function Home(){

  const MultiListeVin = [
    { Section: 'Vins', 
      Liste: [
        { 
          Id: '1', 
          Icon: '', 
          Title: 'pinot noir', 
          Decription: 'un pinot noir test', 
          DegreeAlcoolo: '', 
          Familly: 'Pinot', 
          Quantity: '30', 
          Provider: 'maison', 
          Price: '19.95' }, 
        { Id: '2', Icon: '', Title: 'vin rouge', Descirption: 'no desc', DegreeAlcoolo: '', Familly: 'Vin', Quantity: '0', Provider: 'no provider', Price: '15' }] }, 
    { Section: 'Vins Pétillants', 
      Liste: [
        { Id: '3', Icon: '', Title: 'pinot noir', Decription: 'un pinot noir test', DegreeAlcoolo: '', Familly: 'Pinot', Quantity: '30', Provider: 'maison', Price: '19.95' }] }]

    return(
      <div>
        <Header />
          {MultiListeVin.map((product) => <ProductList section={product} />)}
        <Footer />
      </div>
    )
}