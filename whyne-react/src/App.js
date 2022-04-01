import './App.css'
import ProductItem from './components/ProductItem'
import ProductList from './components/ProductList'

function App () {
  const ListeVin = [{ Id: '1', Icon: '', Title: 'pinot noir', Decription: 'un pinot noir test', DegreeAlcoolo: '', Familly: 'Pinot', Quantity: '30', Provider: 'maison', Price: '19.95' }, { Id: '2', Icon: '', Title: 'vin rouge', Descirption: 'no desc', DegreeAlcoolo: '', Familly: 'Vin', Quantity: '0', Provider: 'no provider', Price: '15' }]
  const MultiListeVin = [{ Section: 'Vins', Liste: ListeVin }, { Section: 'Vins-Petillants', Liste: [{ Id: '1', Icon: '', Title: 'pinot noir', Decription: 'un pinot noir test', DegreeAlcoolo: '', Familly: 'Pinot', Quantity: '30', Provider: 'maison', Price: '19.95' }] }]
  return (
    <>
      <div class='grid-container'>
        <div class='grid-item'>
          {ListeVin.map((product, i) => <ProductItem {...product} key={i} />)}
        </div>
      </div>
      {/* <div class='grid-container'>
        <div class='grid-item'>
          {MultiListeVin.map((section, product, i) => <ProductList section {...product} key={i} />)}
        </div>
      </div> */}
    </>
  )
}

export default App
