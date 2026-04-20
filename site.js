/* TechSolvePro - Site JavaScript */

// Navbar scroll effect
(function () {
    const navbar = document.getElementById('mainNav');
    if (!navbar) return;
    const onScroll = () => {
        navbar.classList.toggle('scrolled', window.scrollY > 60);
    };
    window.addEventListener('scroll', onScroll, { passive: true });
    onScroll();
})();

// Mobile nav toggle
(function () {
    const toggle = document.getElementById('navToggle');
    const menu = document.getElementById('navMenu');
    if (!toggle || !menu) return;

    toggle.addEventListener('click', () => {
        const open = menu.classList.toggle('open');
        toggle.setAttribute('aria-expanded', open ? 'true' : 'false');
        const spans = toggle.querySelectorAll('span');
        if (open) {
            spans[0].style.transform = 'rotate(45deg) translate(5px,5px)';
            spans[1].style.opacity = '0';
            spans[2].style.transform = 'rotate(-45deg) translate(5px,-5px)';
        } else {
            spans[0].style.transform = '';
            spans[1].style.opacity = '';
            spans[2].style.transform = '';
        }
    });

    // Mobile dropdown toggle
    document.querySelectorAll('.nav-item.has-dropdown .nav-link').forEach(link => {
        link.addEventListener('click', function (e) {
            if (window.innerWidth <= 768) {
                e.preventDefault();
                const item = this.closest('.nav-item');
                item.classList.toggle('dropdown-open');
            }
        });
    });

    // Close menu on outside click
    document.addEventListener('click', (e) => {
        if (!menu.contains(e.target) && !toggle.contains(e.target)) {
            menu.classList.remove('open');
        }
    });
})();

// Back to top
(function () {
    const btn = document.getElementById('backToTop');
    if (!btn) return;
    window.addEventListener('scroll', () => {
        btn.classList.toggle('visible', window.scrollY > 400);
    }, { passive: true });
    btn.addEventListener('click', (e) => {
        e.preventDefault();
        window.scrollTo({ top: 0, behavior: 'smooth' });
    });
})();

// Testimonial slider
(function () {
    const slider = document.getElementById('testimonialSlider');
    const dotsContainer = document.getElementById('sliderDots');
    if (!slider || !dotsContainer) return;

    const cards = slider.querySelectorAll('.testimonial-card');
    if (cards.length <= 2) return;

    let currentPage = 0;
    const itemsPerPage = 2;
    const totalPages = Math.ceil(cards.length / itemsPerPage);

    const showPage = (page) => {
        cards.forEach((card, idx) => {
            const pageIdx = Math.floor(idx / itemsPerPage);
            card.style.display = pageIdx === page ? '' : 'none';
        });
        document.querySelectorAll('.slider-dot').forEach((dot, i) => {
            dot.classList.toggle('active', i === page);
        });
        currentPage = page;
    };

    // Create dots
    for (let i = 0; i < totalPages; i++) {
        const dot = document.createElement('button');
        dot.className = 'slider-dot' + (i === 0 ? ' active' : '');
        dot.setAttribute('aria-label', `Page ${i + 1}`);
        dot.addEventListener('click', () => showPage(i));
        dotsContainer.appendChild(dot);
    }

    // Auto-advance
    let timer = setInterval(() => showPage((currentPage + 1) % totalPages), 5000);
    slider.addEventListener('mouseenter', () => clearInterval(timer));
    slider.addEventListener('mouseleave', () => {
        timer = setInterval(() => showPage((currentPage + 1) % totalPages), 5000);
    });

    showPage(0);
})();

// Add slider dot styles inline
(function () {
    const style = document.createElement('style');
    style.textContent = `.slider-dot{width:10px;height:10px;border-radius:50%;background:var(--neutral-300);border:none;cursor:pointer;transition:all .25s;margin:0 4px;}.slider-dot.active{background:var(--primary-400);transform:scale(1.2);}#sliderDots{text-align:center;margin-top:24px;}`;
    document.head.appendChild(style);
})();

// Intersection observer for fade-in animations
(function () {
    const style = document.createElement('style');
    style.textContent = `.fade-in{opacity:0;transform:translateY(24px);transition:opacity .6s ease,transform .6s ease;}.fade-in.visible{opacity:1;transform:none;}`;
    document.head.appendChild(style);

    const targets = document.querySelectorAll('.service-card, .portfolio-card, .blog-card, .perk-card, .stat-item, .why-feature, .tech-cat');
    if (!targets.length || !window.IntersectionObserver) return;

    targets.forEach(el => el.classList.add('fade-in'));

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('visible');
                observer.unobserve(entry.target);
            }
        });
    }, { threshold: 0.1, rootMargin: '0px 0px -40px 0px' });

    targets.forEach(el => observer.observe(el));
})();

// Job department filter
(function () {
    const tabs = document.querySelectorAll('.job-tab');
    if (!tabs.length) return;

    tabs.forEach(tab => {
        tab.addEventListener('click', function () {
            tabs.forEach(t => t.classList.remove('active'));
            this.classList.add('active');
            const dept = this.dataset.dept;
            document.querySelectorAll('.job-card').forEach(card => {
                if (dept === 'all' || card.dataset.dept === dept) {
                    card.style.display = '';
                } else {
                    card.style.display = 'none';
                }
            });
        });
    });
})();

// Apply form toggle
function toggleApplyForm(btn) {
    const card = btn.closest('.job-card');
    const formWrapper = card.querySelector('.apply-form-wrapper');
    const isOpen = formWrapper.style.display !== 'none';
    formWrapper.style.display = isOpen ? 'none' : 'block';
    btn.classList.toggle('open', !isOpen);
    btn.innerHTML = isOpen
        ? 'Apply Now <i class="fas fa-chevron-down"></i>'
        : 'Close <i class="fas fa-chevron-up"></i>';
}

// Smooth scroll for anchor links
document.querySelectorAll('a[href^="#"]').forEach(a => {
    a.addEventListener('click', function (e) {
        const target = document.querySelector(this.getAttribute('href'));
        if (target) {
            e.preventDefault();
            target.scrollIntoView({ behavior: 'smooth', block: 'start' });
        }
    });
});
