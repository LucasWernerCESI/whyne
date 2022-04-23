import ProductItem from './ProductItem'

export default function Product ({section}) {

  return (
      <section id={section.Section}>
        <h1>{section.Section}</h1>
        <div className='grid-container'>
          {section.Liste.map((product, i) => <ProductItem {...product} key={i} />)}
        </div>
      </section>

  )
};
