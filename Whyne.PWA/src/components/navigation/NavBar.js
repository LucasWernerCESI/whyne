import { Link, animateScroll as scroll } from 'react-scroll'

export default function NavBar ({ section }) {
  console.log(section)
  const ST = '#' + section.Section
  console.log(ST)
  return (
    <li><a href={ST}>{section.Section}</a></li>
  )
};
