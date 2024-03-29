/**
 * Template Name: DevFolio - v4.7.1
 * Template URL: https://bootstrapmade.com/devfolio-bootstrap-portfolio-html-template/
 * Author: BootstrapMade.com
 * License: https://bootstrapmade.com/license/
 */
(function () {
  "use strict";

  /**
   * Easy selector helper function
   */
  const select = (el, all = false) => {
    el = el.trim()
    if (all) {
      return [...document.querySelectorAll(el)]
    } else {
      return document.querySelector(el)
    }
  }

  /**
   * Easy event listener function
   */
  const on = (type, el, listener, all = false) => {
    let selectEl = select(el, all)
    if (selectEl) {
      if (all) {
        selectEl.forEach(e => e.addEventListener(type, listener))
      } else {
        selectEl.addEventListener(type, listener)
      }
    }
  }

  /**
   * Easy on scroll event listener 
   */
  const onscroll = (el, listener) => {
    el.addEventListener('scroll', listener)
  }

  /**
   * Navbar links active state on scroll
   */
  let navbarlinks = select('#navbar .scrollto', true)
  const navbarlinksActive = () => {
    let position = window.scrollY + 200
    navbarlinks.forEach(navbarlink => {
      if (!navbarlink.hash) return
      let section = select(navbarlink.hash)
      if (!section) return
      if (position >= section.offsetTop && position <= (section.offsetTop + section.offsetHeight)) {
        navbarlink.classList.add('active')
      } else {
        navbarlink.classList.remove('active')
      }
    })
  }
  window.addEventListener('load', navbarlinksActive)
  onscroll(document, navbarlinksActive)

  /**
   * Scrolls to an element with header offset
   */
  const scrollto = (el) => {
    let header = select('#header')
    let offset = header.offsetHeight

    if (!header.classList.contains('header-scrolled')) {
      offset -= 16
    }

    let elementPos = select(el).offsetTop
    window.scrollTo({
      top: elementPos - offset,
      behavior: 'smooth'
    })
  }

  /**
   * Toggle .header-scrolled class to #header when page is scrolled
   */
  let selectHeader = select('#header')
  if (selectHeader) {
    const headerScrolled = () => {
      if (window.scrollY > 100) {
        selectHeader.classList.add('header-scrolled')
      } else {
        selectHeader.classList.remove('header-scrolled')
      }
    }
    window.addEventListener('load', headerScrolled)
    onscroll(document, headerScrolled)
  }

  /**
   * Back to top button
   */
  let backtotop = select('.back-to-top')
  if (backtotop) {
    const toggleBacktotop = () => {
      if (window.scrollY > 100) {
        backtotop.classList.add('active')
      } else {
        backtotop.classList.remove('active')
      }
    }
    window.addEventListener('load', toggleBacktotop)
    onscroll(document, toggleBacktotop)
  }

  /**
   * Mobile nav toggle
   */
  on('click', '.mobile-nav-toggle', function (e) {
    select('#navbar').classList.toggle('navbar-mobile')
    this.classList.toggle('bi-list')
    this.classList.toggle('bi-x')
  })

  /**
   * Mobile nav dropdowns activate
   */
  on('click', '.navbar .dropdown > a', function (e) {
    if (select('#navbar').classList.contains('navbar-mobile')) {
      e.preventDefault()
      this.nextElementSibling.classList.toggle('dropdown-active')
    }
  }, true)

  /**
   * Scrool with ofset on links with a class name .scrollto
   */
  on('click', '.scrollto', function (e) {
    if (select(this.hash)) {
      e.preventDefault()

      let navbar = select('#navbar')
      if (navbar.classList.contains('navbar-mobile')) {
        navbar.classList.remove('navbar-mobile')
        let navbarToggle = select('.mobile-nav-toggle')
        navbarToggle.classList.toggle('bi-list')
        navbarToggle.classList.toggle('bi-x')
      }
      scrollto(this.hash)
    }
  }, true)

  /**
   * Scroll with ofset on page load with hash links in the url
   */
  window.addEventListener('load', () => {
    if (window.location.hash) {
      if (select(window.location.hash)) {
        scrollto(window.location.hash)
      }
    }
  });

  /**
   * Intro type effect
   */
  const typed = select('.typed')
  if (typed) {
    let typed_strings = typed.getAttribute('data-typed-items')
    typed_strings = typed_strings.split(',')
    new Typed('.typed', {
      strings: typed_strings,
      loop: true,
      typeSpeed: 100,
      backSpeed: 50,
      backDelay: 2000
    });
  }

  /**
   * Initiate portfolio lightbox 
   */
  const portfolioLightbox = GLightbox({
    selector: '.portfolio-lightbox'
  });

  /**
   * Testimonials slider
   */
  new Swiper('.testimonials-slider', {
    speed: 600,
    loop: true,
    autoplay: {
      delay: 5000,
      disableOnInteraction: false
    },
    slidesPerView: 'auto',
    pagination: {
      el: '.swiper-pagination',
      type: 'bullets',
      clickable: true
    }
  });

  /**
   * Portfolio details slider
   */
  new Swiper('.portfolio-details-slider', {
    speed: 400,
    loop: true,
    autoplay: {
      delay: 5000,
      disableOnInteraction: false
    },
    pagination: {
      el: '.swiper-pagination',
      type: 'bullets',
      clickable: true
    }
  });

  /**
   * Preloader
   */
  let preloader = select('#preloader');
  if (preloader) {
    window.addEventListener('load', () => {
      preloader.remove()
    });
  }

})()

// $(document).ready(function(){
//   document.querySelectorAll(".comment-children .parent-coment").forEach(function (e) {

//     e.addEventListener("mouseenter", function (x) {
//       let parent = document.getElementById(x.target.getAttribute("data-parent"))
//       parent.style.backgroundColor = "yellow"
//     })
  
//     e.addEventListener("mouseleave", function (x) {
//       let parent = document.getElementById(x.target.getAttribute("data-parent"))
//       parent.style.backgroundColor = "white"
//     })
  
//   })
// })




document.querySelectorAll(".replay").forEach(function (e) {

  e.addEventListener("click", function (x) {
    x.preventDefault();

    let parent = x.target.parentElement
    const elemet = x.target
    let isAdded = elemet.getAttribute("data-add")
    
    if (isAdded == "0") {
      elemet.setAttribute("data-add", "1")
      let userId = x.target.getAttribute("data-userid")
      let commentId = x.target.getAttribute("data-commentid")
      let comment = ComentCreate(userId, commentId)
      parent.appendChild(comment)

      Vaildation(comment)
      let canceled = comment.children[2].children[0]
      // Remove Form
      canceled.addEventListener("click", function (x) {
        let comment = x.target.parentElement.parentElement
        RemoveForm(comment)
        elemet.setAttribute("data-add", "0")
      })

    }

  })
})


function ComentCreate(userId, comment) {
  let form = document.createElement("form")
  form.setAttribute("class", "d-block mt-3")
  form.setAttribute("action", "/Location")

  let html = `
  <div class="mb-3">
    <div class="form-group">
      <textarea id="textMessage" class="form-control input-mf" placeholder="Comment *" name="message" cols="45" rows="8" required></textarea>
      <input type="hidden" name="userId" value="%user">
      <input type="hidden" name="commetId" value="%coment">
      <span class="text-danger"></span>
    </div>
  </div>
  <div class="d-inline-block mt-2" >
      <button type="submit" class="button button-a button-rouded">Send Message</button>
  </div>
  <div class="d-inline-block mt-2">
      <button type="button" class="button canceled button-a button-rouded">Cancel</button>
  </div>
  `
  html = html.replace("%user", userId)
  html = html.replace("%coment", comment)
  form.innerHTML = html
  return form
}

function RemoveForm(comment) {
  let parent = comment.parentElement
  parent.removeChild(comment)
}

function Vaildation(form){
  form.addEventListener("submit", function (x) {
    x.preventDefault();
    const div = x.target.children[0].children[0]
    let textarea = div.children[0].value.trim()
    let user = div.children[1].value
    let commentId = div.children[2].value
    if (!textarea || textarea == undefined || textarea == "" || textarea.length == 0) {
      x.preventDefault()
      div.children[3].innerText = "Please Comment Add"
    }

    if(user==0){
      x.preventDefault()
      div.children[3].innerText = "Please Sign In Or Sign Up"
    }

    if(commentId == undefined || commentId == ""){
      location.href = location.href
    }

    SendComment(textarea,user,commentId)
  })
}


function SendComment(commnet,user,commentId){
  $(document).ready(()=>{
    
  })
}



document.querySelector(".comment-leave").addEventListener("submit",function(e){
  const div = e.target.children[0].children[0].children[0]
  let textarea = div.children[0].value.trim()
  let user = div.children[1].value
  let errorText = document.querySelector(".danger")
  if (!textarea || textarea == undefined || textarea == "" || textarea.length == 0) {
    e.preventDefault()
    errorText.innerHTML = "Please Comment Add"
  }

  if(user==0){
    e.preventDefault()
    errorText.innerHTML = "Please Sign In Or Sign Up"
  }
  
})



