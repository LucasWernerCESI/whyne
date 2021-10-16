import { useLocation } from "react-router";

function Breadcrumb () {
    const {pathname} = useLocation();
    const route = 
        (pathname !== "/" )
            ? pathname.substring(1).split('/').map(r => r.charAt(0).toUpperCase() + r.slice(1) ) 
            : ["home"];

    return (
        <div>
            {route && route.join(" > ") }
        </div>
    );

}

export default Breadcrumb;