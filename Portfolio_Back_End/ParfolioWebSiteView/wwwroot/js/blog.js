// Parent Comment Location
$(document).ready(function () {
    document.querySelectorAll(".comment-children .parent-coment").forEach(function (e) {

        e.addEventListener("mouseenter", function (x) {
            let parent = document.getElementById(x.target.getAttribute("data-parent"))
            parent.style.backgroundColor = "yellow"
        })

        e.addEventListener("mouseleave", function (x) {
            let parent = document.getElementById(x.target.getAttribute("data-parent"))
            parent.style.backgroundColor = "white"
        })

    })
})




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
            let blogId = x.target.getAttribute("data-blog")

            let comment = ComentCreate(userId, commentId, blogId)
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


function ComentCreate(userId, comment,blogId) {
    let form = document.createElement("form")
    form.setAttribute("class", "d-block mt-3")
    form.setAttribute("action", "/Location")

    let html =
    `
      <div class="mb-3">
        <div class="form-group">
          <textarea id="textMessage" class="form-control input-mf" placeholder="Comment *" name="message" cols="45" rows="8" required></textarea>
          <input type="hidden" name="userId" value="%user">
          <input type="hidden" name="commetId" value="%coment">
          <input type="hidden" name="blogId" value="%blog">
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
    html = html.replace("%blog", blogId)
    form.innerHTML = html
    return form
}

function RemoveForm(comment) {
    let parent = comment.parentElement
    parent.removeChild(comment)
}

function Vaildation(form) {
    form.addEventListener("submit", function (x) {
        x.preventDefault();
        const div = x.target.children[0].children[0]
        let textarea = div.children[0].value.trim()
        let user = div.children[1].value
        let ParentId = div.children[2].value
        let blogId = div.children[3].value

        if (!textarea || textarea == undefined || textarea == "" || textarea.length == 0) {
            x.preventDefault()
            div.children[4].innerText = "Please Comment Add"
        }

        if (user == 0) {
            x.preventDefault()
            div.children[4].innerText = "Please Sign In Or Sign Up"
        }

        if (ParentId == undefined || ParentId == "" || ParentId < 0) {
            location.href = location.href
        }

        SendComment(textarea, user, ParentId, blogId)
    })
}


document.querySelectorAll(".more-btn").forEach(elment => {
    elment.addEventListener("click", function () {
        $(elment.nextElementSibling).toggleClass("show");
    })
})



