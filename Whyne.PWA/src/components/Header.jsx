export default function Product ({section}) {

  const ST = "#"+section.Section

  return (
    <>
      <li><a href={ST} >{section.Section}</a></li>
    </>
  )
};
