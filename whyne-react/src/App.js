import "./index.css"
import "./App.css"
import products from "./assets/products.json"
import Product from "./components/Product";

export default function App() {
  return (
      <div className={"container"}>
        <main className={"main"}>
          <div className={"grid"}>
            {
              products.map((product, i) => <Product {...product} key={i}/>)
            }
          </div>
        </main>
        <div
            id="snipcart"
            data-api-key="ZjhiNjhlYzYtZDcxYy00MGIyLWJkOGUtOTc5OTViZmQ0OTc3NjM3ODMxOTE0MTE1NDMwNjY4" hidden
        >
        </div>
      </div>
  );
}
