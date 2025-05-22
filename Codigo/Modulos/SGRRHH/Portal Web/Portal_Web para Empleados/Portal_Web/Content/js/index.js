document.addEventListener('DOMContentLoaded', function() {
    // Obtener la información del usuario que inició sesión
    getCurrentUser().then(user => {
        if (user) {
            // Actualizar la información del usuario en la interfaz
            updateUserInfo(user);

            const navLinks = document.querySelectorAll('.nav-item a');
            const contentArea = document.getElementById('contentArea');

            navLinks.forEach(link => {
                link.addEventListener('click', function(e) {
                    e.preventDefault();
                    
                    // Remover clase active de todos los items
                    navLinks.forEach(l => l.parentElement.classList.remove('active'));
                    
                    // Agregar clase active al item clickeado
                    this.parentElement.classList.add('active');

                    // Obtener la sección a cargar
                    const section = this.getAttribute('data-section');
                    
                    // Cerrar el menú en móviles
                    if (window.innerWidth <= 768) {
                        const sidebar = document.getElementById('sidebar');
                        sidebar.classList.remove('active');
                    }

                    // Cargar el contenido de la sección
                    loadSection(section, user);
                });
            });
        } else {
            // Si no hay usuario, redirigir al login
            window.location.href = '/Account/Login';
        }
    }).catch(error => {
        console.error('Error al obtener información del usuario:', error);
        // En caso de error, redirigir al login
        window.location.href = '/Account/Login';
    });

    function getCurrentUser() {
        return fetch('/Home/GetCurrentUser')
            .then(response => {
                if (!response.ok) {
                    throw new Error('No se pudo obtener la información del usuario');
                }
                return response.json();
            })
            .then(data => {
                // Transformar los datos del servidor al formato que espera la interfaz
                return {
                    userId: data.userId,
                    userName: data.userName,
                    email: data.email,
                    roleId: data.roleId,
                    roleName: data.roleName,
                    department: data.department || 'No especificado',
                    position: data.position || 'No especificado',
                    joinDate: data.joinDate || 'No especificada'
                };
            });
    }

    function updateUserInfo(user) {
        // Actualizar información en el sidebar
        const userDetails = document.querySelector('.user-details');
        if (userDetails) {
            const userNameElement = userDetails.querySelector('h3');
            const positionElement = userDetails.querySelector('span');
            if (userNameElement) userNameElement.textContent = user.userName;
            if (positionElement) positionElement.textContent = user.position;
        }

        // Actualizar información en el menú de usuario
        const userMenu = document.querySelector('.user-menu .dropdown-toggle span');
        if (userMenu) {
            userMenu.textContent = user.userName;
        }

        // Actualizar información en el avatar pequeño
        const userAvatarSmall = document.querySelector('.user-avatar-small');
        if (userAvatarSmall) {
            const avatarIcon = userAvatarSmall.querySelector('i');
            if (avatarIcon) {
                avatarIcon.style.color = getAvatarColor(user.userId); // Función para asignar color único
            }
        }
    }

    function getAvatarColor(userId) {
        // Generar un color único basado en el ID del usuario
        const colors = [
            '#1abc9c', '#2ecc71', '#3498db', '#9b59b6', '#34495e',
            '#16a085', '#27ae60', '#2980b9', '#8e44ad', '#2c3e50',
            '#f1c40f', '#e67e22', '#e74c3c', '#95a5a6', '#f39c12',
            '#d35400', '#c0392b', '#bdc3c7', '#7f8c8d'
        ];
        return colors[userId % colors.length];
    }

    function initializeUserMenu() {
        const userMenu = document.querySelector('.user-menu');
        if (!userMenu) return; // Si no existe el menú, salimos

        // Remover listeners anteriores si existen
        const oldDropdownToggle = userMenu.querySelector('.dropdown-toggle');
        if (oldDropdownToggle) {
            const newDropdownToggle = oldDropdownToggle.cloneNode(true);
            oldDropdownToggle.parentNode.replaceChild(newDropdownToggle, oldDropdownToggle);
        }

        const dropdownToggle = userMenu.querySelector('.dropdown-toggle');
        const dropdownMenu = userMenu.querySelector('.dropdown-menu');
        
        if (!dropdownToggle || !dropdownMenu) return;

        // Manejar clic en el toggle
        dropdownToggle.addEventListener('click', function(e) {
            e.stopPropagation();
            const isOpen = dropdownMenu.classList.contains('show');
            
            // Cerrar todos los menús desplegables
            document.querySelectorAll('.dropdown-menu').forEach(menu => {
                menu.classList.remove('show');
            });

            // Alternar el menú actual
            if (!isOpen) {
                dropdownMenu.classList.add('show');
            }
        });

        // Cerrar el menú al hacer clic fuera
        document.addEventListener('click', function(e) {
            if (!userMenu.contains(e.target)) {
                dropdownMenu.classList.remove('show');
            }
        });

        // Cerrar el menú al hacer clic en un enlace del menú
        dropdownMenu.querySelectorAll('a').forEach(link => {
            link.addEventListener('click', function() {
                dropdownMenu.classList.remove('show');
            });
        });
    }

    function loadSection(section, user) {
        const contentArea = document.getElementById('contentArea');
        const content = getSectionContent(section, user);
        contentArea.innerHTML = content;
        
        // Reinicializar el menú de usuario después de cargar cada sección
        initializeUserMenu();
    }

    function getSectionContent(section, user) {
        // Crear la barra superior común para todas las secciones
        const commonTopBar = `
            <header class="top-bar">
                <div class="search-container">
                    <div class="search-box">
                        <i class="fas fa-search"></i>
                        <input type="text" placeholder="Buscar...">
                    </div>
                </div>
                <div class="top-bar-right">
                    <div class="notifications">
                        <button class="notification-btn">
                            <i class="fas fa-bell"></i>
                            <span class="badge">3</span>
                        </button>
                    </div>
                    <div class="user-menu">
                        <div class="dropdown-toggle">
                            <div class="user-avatar-small">
                                <i class="fas fa-user"></i>
                            </div>
                            <span>${user.userName}</span>
                        </div>
                        <div class="dropdown-menu">
                            <a href="#" data-section="perfil">
                                <i class="fas fa-user"></i> Mi Perfil
                            </a>
                            <a href="#" data-section="documentos">
                                <i class="fas fa-file-alt"></i> Mis Documentos
                            </a>
                            <div class="dropdown-divider"></div>
                            <a href="/Home/Logout">
                                <i class="fas fa-sign-out-alt"></i> Cerrar Sesión
                            </a>
                        </div>
                    </div>
                </div>
            </header>
        `;

        // Aquí puedes definir el contenido HTML para cada sección
        const sections = {
            dashboard: `
                ${commonTopBar}
                <div class="dashboard">
                    <div class="welcome-section">
                        <h1>Bienvenido, ${user.userName}</h1>
                        <p>Aquí está el resumen de tu actividad</p>
                    </div>

                    <div class="quick-stats">
                        <div class="stat-card">
                            <div class="stat-icon">
                                <i class="fas fa-clock"></i>
                            </div>
                            <div class="stat-info">
                                <h3>Horas Trabajadas</h3>
                                <p class="stat-value">164h</p>
                                <span class="stat-period">Este mes</span>
                            </div>
                        </div>

                        <div class="stat-card">
                            <div class="stat-icon">
                                <i class="fas fa-calendar-check"></i>
                            </div>
                            <div class="stat-info">
                                <h3>Días Disponibles</h3>
                                <p class="stat-value">15</p>
                                <span class="stat-period">Vacaciones</span>
                            </div>
                        </div>

                        <div class="stat-card">
                            <div class="stat-icon">
                                <i class="fas fa-file-alt"></i>
                            </div>
                            <div class="stat-info">
                                <h3>Documentos</h3>
                                <p class="stat-value">3</p>
                                <span class="stat-period">Pendientes</span>
                            </div>
                        </div>

                        <div class="stat-card">
                            <div class="stat-icon">
                                <i class="fas fa-tasks"></i>
                            </div>
                            <div class="stat-info">
                                <h3>Proyectos</h3>
                                <p class="stat-value">4</p>
                                <span class="stat-period">Activos</span>
                            </div>
                        </div>
                    </div>

                    <div class="dashboard-grid">
                        <div class="grid-item attendance-chart">
                            <div class="card">
                                <div class="card-header">
                                    <h2>Registro de Asistencia</h2>
                                    <div class="card-actions">
                                        <button class="btn-icon">
                                            <i class="fas fa-ellipsis-v"></i>
                                        </button>
                                    </div>
                                </div>
                                <div class="card-body">
                                    <div class="chart-placeholder"></div>
                                </div>
                            </div>
                        </div>

                        <div class="grid-item upcoming-events">
                            <div class="card">
                                <div class="card-header">
                                    <h2>Próximos Eventos</h2>
                                    <div class="card-actions">
                                        <button class="btn-icon">
                                            <i class="fas fa-plus"></i>
                                        </button>
                                    </div>
                                </div>
                                <div class="card-body">
                                    <ul class="events-list">
                                        <li class="event-item">
                                            <div class="event-date">
                                                <span class="day">15</span>
                                                <span class="month">MAR</span>
                                            </div>
                                            <div class="event-details">
                                                <h4>Reunión de Equipo</h4>
                                                <p>10:00 AM - Sala de Conferencias</p>
                                            </div>
                                        </li>
                                        <li class="event-item">
                                            <div class="event-date">
                                                <span class="day">18</span>
                                                <span class="month">MAR</span>
                                            </div>
                                            <div class="event-details">
                                                <h4>Revisión de Proyecto</h4>
                                                <p>2:30 PM - Sala Virtual</p>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            `,
            perfil: `
                ${commonTopBar}
                <div class="profile-section">
                    <div class="profile-header">
                        <div class="profile-avatar">
                            <i class="fas fa-user-circle"></i>
                        </div>
                        <h2>${user.userName}</h2>
                        <p>${user.position}</p>
                    </div>
                    <div class="profile-content">
                        <div class="profile-card">
                            <h3>Información Personal</h3>
                            <div class="info-grid">
                                <div class="info-item">
                                    <label>Email</label>
                                    <p>${user.email}</p>
                                </div>
                                <div class="info-item">
                                    <label>Departamento</label>
                                    <p>${user.department}</p>
                                </div>
                                <div class="info-item">
                                    <label>Cargo</label>
                                    <p>${user.position}</p>
                                </div>
                                <div class="info-item">
                                    <label>Fecha de Ingreso</label>
                                    <p>${user.joinDate}</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            `,
            asistencia: `
                ${commonTopBar}
                <div class="attendance-section">
                    <div class="attendance-card">
                        <div class="attendance-header">
                            <h2>Registro de Entrada/Salida</h2>
                            <button class="btn-primary">Registrar Asistencia</button>
                        </div>
                        <div class="attendance-content">
                            <div class="attendance-stats">
                                <div class="stat-item">
                                    <span class="label">Entrada</span>
                                    <span class="value">8:30 AM</span>
                                </div>
                                <div class="stat-item">
                                    <span class="label">Salida</span>
                                    <span class="value">5:30 PM</span>
                                </div>
                                <div class="stat-item">
                                    <span class="label">Horas Trabajadas</span>
                                    <span class="value">9h</span>
                                </div>
                            </div>
                            <div class="attendance-history">
                                <h3>Historial</h3>
                                <div class="history-list">
                                    <!-- Aquí iría el historial de asistencia -->
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            `,
            vacaciones: `
                ${commonTopBar}
                <div class="vacations-section">
                    <div class="vacations-card">
                        <div class="vacations-header">
                            <h2>Solicitud de Vacaciones</h2>
                            <button class="btn-primary">Nueva Solicitud</button>
                        </div>
                        <div class="vacations-content">
                            <div class="vacations-stats">
                                <div class="stat-item">
                                    <span class="label">Días Disponibles</span>
                                    <span class="value">15</span>
                                </div>
                                <div class="stat-item">
                                    <span class="label">Días Tomados</span>
                                    <span class="value">5</span>
                                </div>
                                <div class="stat-item">
                                    <span class="label">Pendientes</span>
                                    <span class="value">2</span>
                                </div>
                            </div>
                            <div class="vacations-calendar">
                                <h3>Calendario de Vacaciones</h3>
                                <!-- Aquí iría el calendario -->
                            </div>
                        </div>
                    </div>
                </div>
            `,
            documentos: `
                ${commonTopBar}
                <div class="documents-section">
                    <div class="documents-card">
                        <div class="documents-header">
                            <h2>Mis Documentos</h2>
                            <button class="btn-primary">Subir Documento</button>
                        </div>
                        <div class="documents-content">
                            <div class="documents-list">
                                <div class="document-item">
                                    <i class="fas fa-file-pdf"></i>
                                    <div class="document-info">
                                        <h3>Contrato de Trabajo</h3>
                                        <p>PDF - 2.5 MB</p>
                                    </div>
                                    <div class="document-actions">
                                        <button class="btn-icon"><i class="fas fa-download"></i></button>
                                        <button class="btn-icon"><i class="fas fa-trash"></i></button>
                                    </div>
                                </div>
                                <!-- Más documentos aquí -->
                            </div>
                        </div>
                    </div>
                </div>
            `,
            nomina: `
                ${commonTopBar}
                <div class="payroll-section">
                    <div class="payroll-card">
                        <div class="payroll-header">
                            <h2>Información de Nómina</h2>
                            <button class="btn-primary">Descargar Recibo</button>
                        </div>
                        <div class="payroll-content">
                            <div class="payroll-summary">
                                <div class="summary-item">
                                    <span class="label">Salario Base</span>
                                    <span class="value">$5,000.00</span>
                                </div>
                                <div class="summary-item">
                                    <span class="label">Bonos</span>
                                    <span class="value">$500.00</span>
                                </div>
                                <div class="summary-item">
                                    <span class="label">Deducciones</span>
                                    <span class="value">$1,000.00</span>
                                </div>
                                <div class="summary-item total">
                                    <span class="label">Total</span>
                                    <span class="value">$4,500.00</span>
                                </div>
                            </div>
                            <div class="payroll-history">
                                <h3>Historial de Pagos</h3>
                                <!-- Aquí iría el historial de pagos -->
                            </div>
                        </div>
                    </div>
                </div>
            `
        };

        return sections[section] || sections.dashboard;
    }

    // Inicializar el menú de usuario cuando se carga la página
    initializeUserMenu();
}); 