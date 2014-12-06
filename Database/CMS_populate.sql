SET foreign_key_checks = 0;

TRUNCATE TABLE CourseMinorArea;
TRUNCATE TABLE CourseMajorArea;
TRUNCATE TABLE StudentMinor;
TRUNCATE TABLE StudentMajor;
TRUNCATE TABLE MinorArea;
TRUNCATE TABLE MajorThematicArea;
TRUNCATE TABLE MajorArea;
TRUNCATE TABLE CourseEquivalent;
TRUNCATE TABLE StandingPrerequisite;
TRUNCATE TABLE CourseCorequisite;
TRUNCATE TABLE CoursePrerequisite;
TRUNCATE TABLE Course;
TRUNCATE TABLE Minor;
TRUNCATE TABLE Major;
TRUNCATE TABLE School;
TRUNCATE TABLE Student;
TRUNCATE TABLE Standing;
TRUNCATE TABLE EnrollStatus;
TRUNCATE TABLE Enroll;

SET foreign_key_checks = 1;


-- Populate table Standing
INSERT INTO Standing VALUES (1, 'Freshman');
INSERT INTO Standing VALUES (2, 'Sophomore');
INSERT INTO Standing VALUES (3, 'Junior');
INSERT INTO Standing VALUES (4, 'Senior');

-- Populate table EnrollStatus
INSERT INTO EnrollStatus VALUES ('P', 'Passed');
INSERT INTO EnrollStatus VALUES ('F', 'Failed');
INSERT INTO EnrollStatus VALUES ('C', 'Currently Enrolled');

-- Populate table Student
INSERT INTO Student VALUES (11111, 'Adams', 'Aaron', 2);
INSERT INTO Student VALUES (11112, 'Bush', 'Beatrice', 1);


-- Populate table School
INSERT INTO School VALUES ('SBA', 'School of Business Administration');
INSERT INTO School VALUES ('SHSS', 'School of Humanities and Social Sciences');
INSERT INTO School VALUES ('SSE', 'School of Science and Engineering');
INSERT INTO School VALUES ('LC', 'Language Center');

-- Populate table Major
INSERT INTO Major VALUES ('BSBA', 'Business Administration', 'SBA', 0);
INSERT INTO Major VALUES ('BSIS', 'International Studies', 'SHSS', 0);
INSERT INTO Major VALUES ('BSHRD', 'Human Resource Development', 'SHSS', 0);
INSERT INTO Major VALUES ('BSCS', 'Communication Studies', 'SHSS', 0);
INSERT INTO Major VALUES ('BSCSC', 'Computer Science', 'SSE', 0);
INSERT INTO Major VALUES ('BSEMS', 'Engineering and Management Science', 'SSE', 1);
INSERT INTO Major VALUES ('BSGE', 'General Engineering', 'SSE', 1);

-- Populate table Minor
INSERT INTO Minor VALUES ('MNLSC', 'Logistics and Supply Chain Management for SSE', 'SBA');
INSERT INTO Minor VALUES ('MNBCS', 'Business Administration for Computer Science', 'SBA');
INSERT INTO Minor VALUES ('MNBHR', 'Business Administration for Human Resource Development', 'SBA');
INSERT INTO Minor VALUES ('MNBCO', 'Business Administration for Communication Studies', 'SBA');
INSERT INTO Minor VALUES ('MNBIS', 'Business Administration for International Studies', 'SBA');
INSERT INTO Minor VALUES ('MNALC', 'Arabic Language and Culture', 'SHSS');
INSERT INTO Minor VALUES ('MNINS', 'International Studies', 'SHSS');
INSERT INTO Minor VALUES ('MNWMS', 'Women\'s Studies', 'SHSS');
INSERT INTO Minor VALUES ('MNAFS', 'African Studies', 'SHSS');
INSERT INTO Minor VALUES ('MNHRD', 'Human Resource Development', 'SHSS');
INSERT INTO Minor VALUES ('MNORS', 'Organizational Studies', 'SHSS');
INSERT INTO Minor VALUES ('MNCOO', 'Communication Studies for SBA and SSE', 'SHSS');
INSERT INTO Minor VALUES ('MNCOH', 'Communication Studies for Human Resource Development Majors', 'SHSS');
INSERT INTO Minor VALUES ('MNCOI', 'Communication Studies for Insernational Studies Majors', 'SHSS');
INSERT INTO Minor VALUES ('MNGE', 'General Engineering', 'SSE');
INSERT INTO Minor VALUES ('MNMTH', 'Mathematics', 'SSE');
INSERT INTO Minor VALUES ('MNCSC', 'Computer Science', 'SSE');

-- Populate table Course
INSERT INTO Course VALUES ('ACC2301','Accounting Principles I',3,'ACC');
INSERT INTO Course VALUES ('ACC2302','Accounting Principles II',3,'ACC');

INSERT INTO Course VALUES ('ALS1001','Academic Listening, Speaking, and Note Taking I',0,'ALS');
INSERT INTO Course VALUES ('ALS1002','Academic Listening, Speaking, and Note Taking II',0,'ALS');
INSERT INTO Course VALUES ('ALS1003','Academic Listening, Speaking, and Note Taking III',0,'ALS');

INSERT INTO Course VALUES ('ARB1309','Arabic For General Purposes',3,'ARB');
INSERT INTO Course VALUES ('ARB1310','Arabic For Academic Purposes',3,'ARB');
INSERT INTO Course VALUES ('ARB1320','Arabic For Communication Purposes',3,'ARB');
INSERT INTO Course VALUES ('ARB2302','Arabic Through The Mass Media',3,'ARB');
INSERT INTO Course VALUES ('ARB2304','Introduction to Arabic Literature',3,'ARB');

INSERT INTO Course VALUES ('ARD1001','Academic Reading I',0,'ARD');
INSERT INTO Course VALUES ('ARD1002','Academic Reading II',0,'ARD');
INSERT INTO Course VALUES ('ARD1003','Academic Reading III',0,'ARD');

INSERT INTO Course VALUES ('AWT1001','Academic Writing I',0,'AWT');
INSERT INTO Course VALUES ('AWT1002','Academic Writing II',0,'AWT');
INSERT INTO Course VALUES ('AWT1003','Academic Writing III',0,'AWT');

INSERT INTO Course VALUES ('BIO1401','Principles of Biology',4,'BIO');
INSERT INTO Course VALUES ('BIO1402','Environmental Biology',4,'BIO');

INSERT INTO Course VALUES ('CHE1400','Chemistry and the Environment',4,'CHE');
INSERT INTO Course VALUES ('CHE1401','General Chemistry I',4,'CHE');
INSERT INTO Course VALUES ('CHE1402','General Chemistry II',4,'CHE');

INSERT INTO Course VALUES ('COM1301','Communication Through Speaking',3,'COM');
INSERT INTO Course VALUES ('COM1302','Introduction to Mass Communication',3,'COM');
INSERT INTO Course VALUES ('COM2301','Professional Communication',3,'COM');
INSERT INTO Course VALUES ('COM2303','International Communication',3,'COM');
INSERT INTO Course VALUES ('COM2304','Introduction to Video and Film Production',3,'COM');
INSERT INTO Course VALUES ('COM2320','Communication Theories',3,'COM');
INSERT INTO Course VALUES ('COM2326','Visual Communication',3,'COM');
INSERT INTO Course VALUES ('COM2425','Print and Online Production Skills',4,'COM');
INSERT INTO Course VALUES ('COM3301','Public Relations Communication',3,'COM');
INSERT INTO Course VALUES ('COM3310','Promotional Communication',3,'COM');
INSERT INTO Course VALUES ('COM3321','Mass Media and Society',3,'COM');
INSERT INTO Course VALUES ('COM3322','Writing for the Media in English',3,'COM');
INSERT INTO Course VALUES ('COM3323','Writing for the Media in French',3,'COM');
INSERT INTO Course VALUES ('COM3324','Writing for the Media in Arabic',3,'COM');
INSERT INTO Course VALUES ('COM3325','Technical Communication Skills',3,'COM');
INSERT INTO Course VALUES ('COM3327','Persuation',3,'COM');
INSERT INTO Course VALUES ('COM3328','Mass Media Texts Analysis',3,'COM');
INSERT INTO Course VALUES ('COM3329','Screen Studies',3,'COM');
INSERT INTO Course VALUES ('COM3330','Organizational Communication',3,'COM');
INSERT INTO Course VALUES ('COM3331','Communication Management',3,'COM');
INSERT INTO Course VALUES ('COM3399','Special Topics in Communication',3,'COM');
INSERT INTO Course VALUES ('COM3425','Technical Communication Skills',3,'COM');
INSERT INTO Course VALUES ('COM4301','Political Communication',3,'COM');
INSERT INTO Course VALUES ('COM4302','Electronic Media Production',3,'COM');
INSERT INTO Course VALUES ('COM4303','Media Economics',3,'COM');
INSERT INTO Course VALUES ('COM4304','Communication and Development',3,'COM');

INSERT INTO Course VALUES ('CSC1400','Introduction to Computers',4,'CSC');
INSERT INTO Course VALUES ('CSC1401','Introduction to Computer Science',4,'CSC');
INSERT INTO Course VALUES ('CSC2302','Data Structures',3,'CSC');
INSERT INTO Course VALUES ('CSC2303','Advanced Programming',3,'CSC');
INSERT INTO Course VALUES ('CSC2304','Computer Architecture',3,'CSC');
INSERT INTO Course VALUES ('CSC3309','Artificial Intelligence',3,'CSC');
INSERT INTO Course VALUES ('CSC3315','Languages and Compilers',3,'CSC');
INSERT INTO Course VALUES ('CSC3323','Algorithm Analysis',3,'CSC');
INSERT INTO Course VALUES ('CSC3324','Software Engineering I',3,'CSC');
INSERT INTO Course VALUES ('CSC3325','Software Engineering II',3,'CSC');
INSERT INTO Course VALUES ('CSC3326','Database Systems',3,'CSC');
INSERT INTO Course VALUES ('CSC3327','Internet Technologies',3,'CSC');
INSERT INTO Course VALUES ('CSC3328','Embedded Systems',3,'CSC');
INSERT INTO Course VALUES ('CSC3341','Computer Graphics',3,'CSC');
INSERT INTO Course VALUES ('CSC3351','Operating Systems',3,'CSC');
INSERT INTO Course VALUES ('CSC3352','Computer Communication',3,'CSC');
INSERT INTO Course VALUES ('CSC3353','Computer Networks',3,'CSC');
INSERT INTO Course VALUES ('CSC3354','Distributed Systems',3,'CSC');
INSERT INTO Course VALUES ('CSC3355','Computer Security',3,'CSC');
INSERT INTO Course VALUES ('CSC3356','Communication Systems',3,'CSC');

INSERT INTO Course VALUES ('ECO1300','Introduction to Economics',3,'ECO');
INSERT INTO Course VALUES ('ECO2301','Microeconomics',3,'ECO');
INSERT INTO Course VALUES ('ECO2302','Macroeconomics',3,'ECO');
INSERT INTO Course VALUES ('ECO2310','Introduction to International Economics',3,'ECO');

INSERT INTO Course VALUES ('EGR1201','Introduction to Engineering and Design',3,'EGR');
INSERT INTO Course VALUES ('EGR1210','Computer Aided Engineering',3,'EGR');
INSERT INTO Course VALUES ('EGR2301','Statistics',3,'EGR');
INSERT INTO Course VALUES ('EGR2302','Engineering Economics',3,'EGR');
INSERT INTO Course VALUES ('EGR2311','Dynamics',3,'EGR');
INSERT INTO Course VALUES ('EGR2312','Mechanics of Materials',3,'EGR');
INSERT INTO Course VALUES ('EGR2402','Electrical Circuits',4,'EGR');
INSERT INTO Course VALUES ('EGR3301','Fluid Mechanics',3,'EGR');
INSERT INTO Course VALUES ('EGR3302','Thermodynamics',3,'EGR');
INSERT INTO Course VALUES ('EGR3304','Materials Science',3,'EGR');
INSERT INTO Course VALUES ('EGR3306','Engineering Instrumentation',3,'EGR');
INSERT INTO Course VALUES ('EGR3308','Thermal Engineering',3,'EGR');
INSERT INTO Course VALUES ('EGR3331','Digital Design',3,'EGR');
INSERT INTO Course VALUES ('EGR3401','Statics for Engineers',4,'EGR');
INSERT INTO Course VALUES ('EGR3402','Statics and Dynamics',4,'EGR');
INSERT INTO Course VALUES ('EGR4300','Internship',3,'EGR');
INSERT INTO Course VALUES ('EGR4402','Capstone Design',4,'EGR');

INSERT INTO Course VALUES ('ENG1301','English Composition I',3,'ENG');
INSERT INTO Course VALUES ('ENG1302','English Composition II',3,'ENG');
INSERT INTO Course VALUES ('ENG2301','Critical Thinking and Written Communication',3,'ENG');
INSERT INTO Course VALUES ('ENG2302','Writing for Business',3,'ENG');
INSERT INTO Course VALUES ('ENG2303','Technical Writing',3,'ENG');

INSERT INTO Course VALUES ('FAS0210','Strategic Academic Skills',2,'FAS');
INSERT INTO Course VALUES ('FAS1220','Introduction to Critical Thinking',2,'FAS');
INSERT INTO Course VALUES ('FAS2210','Graduate Academic Skills',2,'FAS');

INSERT INTO Course VALUES ('FIN3301','Business and Corporate Finance',3,'FIN');

INSERT INTO Course VALUES ('FRN1209','French For Academic Purposes',2,'FRN');
INSERT INTO Course VALUES ('FRN1308','French For Academic Purposes I',3,'FRN');
INSERT INTO Course VALUES ('FRN2210','Advanced French',2,'FRN');
INSERT INTO Course VALUES ('FRN2310','French for Academic Purposes II',3,'FRN');
INSERT INTO Course VALUES ('FRN3310','Advanced French Writing and Speaking Skills',3,'FRN');

INSERT INTO Course VALUES ('GAC1001','Grammar In An Academic Context I',0,'GAC');
INSERT INTO Course VALUES ('GAC1002','Grammar In An Academic Context II',0,'GAC');
INSERT INTO Course VALUES ('GAC1003','Grammar In An Academic Context III',0,'GAC');

INSERT INTO Course VALUES ('GBU3301','Business Statistics',3,'GBU');
INSERT INTO Course VALUES ('GBU3302','Legal Environment',3,'GBU');
INSERT INTO Course VALUES ('GBU3303','Enterprises, Markets and the Moroccan Economy',3,'GBU');
INSERT INTO Course VALUES ('GBU3401','Advanced Quantitative Methods in Business',4,'GBU');
INSERT INTO Course VALUES ('GBU4308','Net-Economics and E-business',3,'GBU');

INSERT INTO Course VALUES ('GEO1301','Introduction to Geography',3,'GEO');

INSERT INTO Course VALUES ('HIS1301','History of the Arab World',3,'HIS');
INSERT INTO Course VALUES ('HIS1302','History of the Arab World in Arabic',3,'HIS');
INSERT INTO Course VALUES ('HIS2301','Contemporary World History',3,'HIS');
INSERT INTO Course VALUES ('HIS3301','Twentieth Century International History',3,'HIS');

INSERT INTO Course VALUES ('HRD2300','Introduction to Human Resource Development',3,'HRD');
INSERT INTO Course VALUES ('HRD2301','Business Environment and Ethics for HRD',3,'HRD');
INSERT INTO Course VALUES ('HRD3301','Human Capital Management',3,'HRD');
INSERT INTO Course VALUES ('HRD3302','Ethics in Professional Contexts',3,'HRD');
INSERT INTO Course VALUES ('HRD3303','Training and Development',3,'HRD');
INSERT INTO Course VALUES ('HRD3304','Strategic HRD',3,'HRD');
INSERT INTO Course VALUES ('HRD3305','Issues in Human/Social Development',3,'HRD');
INSERT INTO Course VALUES ('HRD3399','Special Topics in HRD',3,'HRD');
INSERT INTO Course VALUES ('HRD3401','Human Capital Management',4,'HRD');
INSERT INTO Course VALUES ('HRD4301','Program and Project Management',3,'HRD');
INSERT INTO Course VALUES ('HRD4302','Needs Assessment and Organizational Effectiveness',3,'HRD');
INSERT INTO Course VALUES ('HRD4303','Leadership and Management Development',3,'HRD');
INSERT INTO Course VALUES ('HRD4304','Consulting for HRD',3,'HRD');
INSERT INTO Course VALUES ('HRD4305','Human Resource Development in Public Administration',3,'HRD');
INSERT INTO Course VALUES ('HRD4306','Organizational Development and Change',3,'HRD');

INSERT INTO Course VALUES ('HUM1310','History and CUlture of the Berbers',3,'HUM');
INSERT INTO Course VALUES ('HUM2301','Introduction to Islamic Art and Architecture',3,'HUM');
INSERT INTO Course VALUES ('HUM2302','Intro to the Study of Islamic Civilization',3,'HUM');
INSERT INTO Course VALUES ('HUM2303','Intro to the Study of Islamic Civilization in Arabic',3,'HUM');
INSERT INTO Course VALUES ('HUM2304','Introduction to Islamic Art and Architecture in Arabic',3,'HUM');
INSERT INTO Course VALUES ('HUM2305','Science and Society',3,'HUM');
INSERT INTO Course VALUES ('HUM2306','Comparative Religion',3,'HUM');

INSERT INTO Course VALUES ('INS2320','Model United Nations',3,'INS');
INSERT INTO Course VALUES ('INS3301','Theories and Models of International Relations',3,'INS');
INSERT INTO Course VALUES ('INS3302','International Law and Organizations',3,'INS');
INSERT INTO Course VALUES ('INS3310','The United States and the Middle East',3,'INS');

INSERT INTO Course VALUES ('INT4300','Internship',3,'INT');

INSERT INTO Course VALUES ('LIT2301','Major Works of World Literature',3,'LIT');
INSERT INTO Course VALUES ('LIT2304','Intro to Arabic Literature',3,'LIT');
INSERT INTO Course VALUES ('LIT2305','Intro to World Literature in Arabic',3,'LIT');

INSERT INTO Course VALUES ('MGT3301','Principles of Management',3,'MGT');
INSERT INTO Course VALUES ('MGT3302','Entrepreneurship',3,'MGT');
INSERT INTO Course VALUES ('MGT3303','Operations Management',3,'MGT');
INSERT INTO Course VALUES ('MGT3309','Logistics and Supply Chain Management',3,'MGT');
INSERT INTO Course VALUES ('MGT4301','Capstone Course: Business Policy and Corporate',3,'MGT');
INSERT INTO Course VALUES ('MGT4304','Organizational Behavior',3,'MGT');
INSERT INTO Course VALUES ('MGT4311','Quality Management',3,'MGT');

INSERT INTO Course VALUES ('MIS3301','Management Information Systems',3,'MIS');
INSERT INTO Course VALUES ('MIS3302','Managing the Information Resource',3,'MIS');

INSERT INTO Course VALUES ('MKT3301','Principles of Marketing',3,'MKT');
INSERT INTO Course VALUES ('MKT3302','Advertising and Promotion Management',3,'MKT');
INSERT INTO Course VALUES ('MKT3303','Consumer Behavior',3,'MKT');
INSERT INTO Course VALUES ('MKT4304','Marketing Research',3,'MKT');
INSERT INTO Course VALUES ('MKT4305','Marketing Management',3,'MKT');

INSERT INTO Course VALUES ('MTH1300','Discrete Mathematics',3,'MTH');
INSERT INTO Course VALUES ('MTH1311','Calculus I: Differential Calculus',3,'MTH');
INSERT INTO Course VALUES ('MTH1312','Calculus II: Integral Calculus',3,'MTH');
INSERT INTO Course VALUES ('MTH1304','Discrete Mathematics',3,'MTH');
INSERT INTO Course VALUES ('MTH1388','Introductory Mathematical Thinking',3,'MTH');
INSERT INTO Course VALUES ('MTH1399','Introductory Mathematical Concepts',3,'MTH');
INSERT INTO Course VALUES ('MTH1403','Intensive Differential and Integral Calculus',4,'MTH');
INSERT INTO Course VALUES ('MTH2301','Multivariable Calculus',3,'MTH');
INSERT INTO Course VALUES ('MTH2303','Linear Algebra and Matrix Theory',3,'MTH');
INSERT INTO Course VALUES ('MTH2304','Differential Equations',3,'MTH');
INSERT INTO Course VALUES ('MTH3301','Probability and Statistics for Engineers',3,'MTH');
INSERT INTO Course VALUES ('MTH3302','Complex Variables and Transforms',3,'MTH');

INSERT INTO Course VALUES ('PED1201','Fitness For Living',2,'PED');

INSERT INTO Course VALUES ('PHI2301','Philosophical Thought',3,'PHI');
INSERT INTO Course VALUES ('PHI2302','History of Ideas',3,'PHI');

INSERT INTO Course VALUES ('PHY1400','Conceptual Physics',4,'PHY');
INSERT INTO Course VALUES ('PHY1401','Physics I',4,'PHY');
INSERT INTO Course VALUES ('PHY1402','Physics II',4,'PHY');

INSERT INTO Course VALUES ('PSC2301','Comparative Political Systems',3,'PSC');

INSERT INTO Course VALUES ('PSY1301','Introduction to Psychology',3,'PSY');
INSERT INTO Course VALUES ('PSY3302','Social/Organizational Psychology',3,'PSY');

INSERT INTO Course VALUES ('SOC1301','Principles of Sociology',3,'SOC');

INSERT INTO Course VALUES ('SPN1301','Beginning Spanish I',3,'SPN');

INSERT INTO Course VALUES ('SSC1310','Introduction to Anthropology',3,'SSC');
INSERT INTO Course VALUES ('SSC2315','Sex, Gender, and Power',3,'SSC');
INSERT INTO Course VALUES ('SSC2401','Social Statistics',4,'SSC');
INSERT INTO Course VALUES ('SSC3303','Research Methods',3,'SSC');
INSERT INTO Course VALUES ('SSC3311','Women and Economic Development',3,'SSC');
INSERT INTO Course VALUES ('SSC3315','Women in Culture and the Media',4,'SSC');
INSERT INTO Course VALUES ('SSC3316','Women in Society and Politics',3,'SSC');
INSERT INTO Course VALUES ('SSC4302','Senior Capstone',3,'SSC');

INSERT INTO Course VALUES ('SSK1211','Strategic Learning and Study Skills',2,'SSK');
INSERT INTO Course VALUES ('SSK1212','Information Literacy Skills',2,'SSK');
INSERT INTO Course VALUES ('SSK1213','Critical Thinking and Analysis Skills',2,'SSK');

-- Catalog (2006); SSK courses
INSERT INTO Course VALUES ('SSK1201','Study Skills I',2,'SSK');
INSERT INTO Course VALUES ('SSK1202','Critical Reading & Problem Solving',2,'SSK');
INSERT INTO Course VALUES ('SSK1203','Compt Skills For Independent Learning',2,'SSK');
INSERT INTO Course VALUES ('SSK1204','Applied Independent Learning',2,'SSK');
INSERT INTO Course VALUES ('SSK1205','Interpersonal Skills & Soc. Interaction',2,'SSK');


-- Exchange Program courses
INSERT INTO Course VALUES ('EXC3333','Exchange Program',0,'EXC');

INSERT INTO Course VALUES ('CSCI133','Database Systems',3,'EXC');
INSERT INTO Course VALUES ('ECON086','Accounting For Decision Making',3,'EXC');
INSERT INTO Course VALUES ('MUS 004','Materials of Music',3,'EXC');
INSERT INTO Course VALUES ('POLI110','Intro to Comparative Politic',3,'EXC');

INSERT INTO Course VALUES ('CMSC240','Prin Computer Org',3,'EXC');
INSERT INTO Course VALUES ('CMSC394','Adv Top Theor CMSC',3,'EXC');
INSERT INTO Course VALUES ('MATH215','Linear Algebra',3,'EXC');
INSERT INTO Course VALUES ('MUSC102','Chorale',2,'EXC');
INSERT INTO Course VALUES ('MUSC214','Chamber Singers',2,'EXC');

INSERT INTO Course VALUES ('COM51X','International Communication',3,'EXC');
INSERT INTO Course VALUES ('COM50','Persuasive Speaking & Crit',3,'EXC');
INSERT INTO Course VALUES ('CSC60','Operating Systems',3,'EXC');
INSERT INTO Course VALUES ('M2','Introduction to Discrete Mathematics',3,'EXC');
INSERT INTO Course VALUES ('STA41','Introduction to Probability and Statistics',3,'EXC');

-- Populate table CoursePrerequisite
INSERT INTO CoursePrerequisite VALUES ('ACC2301', 'MTH1300');
INSERT INTO CoursePrerequisite VALUES ('ACC2302', 'ACC2301');

INSERT INTO CoursePrerequisite VALUES ('CHE1402', 'CHE1401');

INSERT INTO CoursePrerequisite VALUES ('COM1301', 'ENG1301');
INSERT INTO CoursePrerequisite VALUES ('COM1302', 'ENG1301');
INSERT INTO CoursePrerequisite VALUES ('COM2301', 'COM1301');
INSERT INTO CoursePrerequisite VALUES ('COM2303', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM2304', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM2320', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM2326', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM2425', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM3301', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM3301', 'COM2301');
INSERT INTO CoursePrerequisite VALUES ('COM3310', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM3310', 'COM2301');
INSERT INTO CoursePrerequisite VALUES ('COM3321', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM3322', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM3323', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM3323', 'FRN3310');
INSERT INTO CoursePrerequisite VALUES ('COM3324', 'ARB1320');
INSERT INTO CoursePrerequisite VALUES ('COM3324', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM3328', 'COM2320');
INSERT INTO CoursePrerequisite VALUES ('COM3329', 'COM1302');
INSERT INTO CoursePrerequisite VALUES ('COM3330', 'COM2301');
INSERT INTO CoursePrerequisite VALUES ('COM4301', 'PSC2301');
INSERT INTO CoursePrerequisite VALUES ('COM4302', 'COM2304');

INSERT INTO CoursePrerequisite VALUES ('CSC2302', 'CSC1401');
INSERT INTO CoursePrerequisite VALUES ('CSC2303', 'CSC2302');
INSERT INTO CoursePrerequisite VALUES ('CSC2304', 'CSC2302');
INSERT INTO CoursePrerequisite VALUES ('CSC2304', 'EGR3331');
INSERT INTO CoursePrerequisite VALUES ('CSC3309', 'CSC2303');
INSERT INTO CoursePrerequisite VALUES ('CSC3315', 'CSC2303');
INSERT INTO CoursePrerequisite VALUES ('CSC3323', 'CSC2303');
INSERT INTO CoursePrerequisite VALUES ('CSC3324', 'CSC2302');
INSERT INTO CoursePrerequisite VALUES ('CSC3325', 'CSC3324');
INSERT INTO CoursePrerequisite VALUES ('CSC3326', 'CSC3324');
INSERT INTO CoursePrerequisite VALUES ('CSC3327', 'CSC3326');
INSERT INTO CoursePrerequisite VALUES ('CSC3328', 'CSC3351');
INSERT INTO CoursePrerequisite VALUES ('CSC3341', 'CSC2302');
INSERT INTO CoursePrerequisite VALUES ('CSC3351', 'CSC2303');
INSERT INTO CoursePrerequisite VALUES ('CSC3351', 'CSC2304');
INSERT INTO CoursePrerequisite VALUES ('CSC3352', 'CSC2303');
INSERT INTO CoursePrerequisite VALUES ('CSC3352', 'CSC2304');
INSERT INTO CoursePrerequisite VALUES ('CSC3353', 'CSC3352');
INSERT INTO CoursePrerequisite VALUES ('CSC3354', 'CSC3351');
INSERT INTO CoursePrerequisite VALUES ('CSC3354', 'CSC3352');
INSERT INTO CoursePrerequisite VALUES ('CSC3354', 'CSC2303');
INSERT INTO CoursePrerequisite VALUES ('CSC3355', 'CSC2303');

INSERT INTO CoursePrerequisite VALUES ('ECO2301', 'MTH1300');
INSERT INTO CoursePrerequisite VALUES ('ECO2302', 'ECO2301');
INSERT INTO CoursePrerequisite VALUES ('ECO2310', 'ECO2301');

INSERT INTO CoursePrerequisite VALUES ('EGR2302', 'MTH1403');
INSERT INTO CoursePrerequisite VALUES ('EGR2402', 'PHY1402');
INSERT INTO CoursePrerequisite VALUES ('EGR3304', 'CHE1402');
INSERT INTO CoursePrerequisite VALUES ('EGR3304', 'PHY1402');
INSERT INTO CoursePrerequisite VALUES ('EGR3306', 'EGR2402');
INSERT INTO CoursePrerequisite VALUES ('EGR3308', 'PHY1402');
INSERT INTO CoursePrerequisite VALUES ('EGR3402', 'MTH2301');
INSERT INTO CoursePrerequisite VALUES ('EGR3402', 'PHY1401');

INSERT INTO CoursePrerequisite VALUES ('ENG1302', 'ENG1301');
INSERT INTO CoursePrerequisite VALUES ('ENG2301', 'ENG1301');
INSERT INTO CoursePrerequisite VALUES ('ENG2301', 'COM1301');
INSERT INTO CoursePrerequisite VALUES ('ENG2302', 'ENG1301');
INSERT INTO CoursePrerequisite VALUES ('ENG2302', 'COM1301');
INSERT INTO CoursePrerequisite VALUES ('ENG2303', 'COM1301');
INSERT INTO CoursePrerequisite VALUES ('ENG2303', 'ENG1301');
INSERT INTO CoursePrerequisite VALUES ('ENG2303', 'SSK1213');

INSERT INTO CoursePrerequisite VALUES ('FIN3301', 'ACC2301');
INSERT INTO CoursePrerequisite VALUES ('FIN3301', 'EGR2302');

INSERT INTO CoursePrerequisite VALUES ('GBU3301', 'MTH1311');
INSERT INTO CoursePrerequisite VALUES ('GBU3401', 'MTH3301');

-- ?? INSERT INTO CoursePrerequisite VALUES ('HIS1302', 'SSK1213');
INSERT INTO CoursePrerequisite VALUES ('HIS2301', 'ENG1301');
INSERT INTO CoursePrerequisite VALUES ('HIS3301', 'HIS1301');

INSERT INTO CoursePrerequisite VALUES ('HRD3303', 'HRD2300');
INSERT INTO CoursePrerequisite VALUES ('HRD3304', 'HRD2300');
INSERT INTO CoursePrerequisite VALUES ('HRD3304', 'HRD3401');
INSERT INTO CoursePrerequisite VALUES ('HRD3305', 'HRD2300');
INSERT INTO CoursePrerequisite VALUES ('HRD4301', 'HRD2300');
INSERT INTO CoursePrerequisite VALUES ('HRD4302', 'HRD2300');
INSERT INTO CoursePrerequisite VALUES ('HRD4302', 'HRD3401');
INSERT INTO CoursePrerequisite VALUES ('HRD4303', 'PSY3302');
INSERT INTO CoursePrerequisite VALUES ('HRD4305', 'HRD2300');
INSERT INTO CoursePrerequisite VALUES ('HRD4305', 'HRD3401');
INSERT INTO CoursePrerequisite VALUES ('HRD4306', 'HRD2300');
INSERT INTO CoursePrerequisite VALUES ('HRD4306', 'HRD3401');

INSERT INTO CoursePrerequisite VALUES ('HUM1310', 'FAS1220');
INSERT INTO CoursePrerequisite VALUES ('HUM2301', 'FAS1220');
INSERT INTO CoursePrerequisite VALUES ('HUM2302', 'FAS1220');
INSERT INTO CoursePrerequisite VALUES ('HUM2303', 'FAS1220');
INSERT INTO CoursePrerequisite VALUES ('HUM2304', 'FAS1220');
INSERT INTO CoursePrerequisite VALUES ('HUM2305', 'FAS1220');
INSERT INTO CoursePrerequisite VALUES ('HUM2306', 'FAS1220');

INSERT INTO CoursePrerequisite VALUES ('INS3301', 'PSC2301');
INSERT INTO CoursePrerequisite VALUES ('INS3302', 'INS3301');

INSERT INTO CoursePrerequisite VALUES ('LIT2301', 'ENG1301');

INSERT INTO CoursePrerequisite VALUES ('MGT3301', 'ACC2301');
INSERT INTO CoursePrerequisite VALUES ('MGT3301', 'EGR2302');
INSERT INTO CoursePrerequisite VALUES ('MGT3302', 'FIN3301');
INSERT INTO CoursePrerequisite VALUES ('MGT3302', 'MGT3301');
INSERT INTO CoursePrerequisite VALUES ('MGT3302', 'MKT3301');
INSERT INTO CoursePrerequisite VALUES ('MGT3303', 'MGT3301');
INSERT INTO CoursePrerequisite VALUES ('MGT3303', 'MTH3301');
INSERT INTO CoursePrerequisite VALUES ('MGT4304', 'MGT3301');

INSERT INTO CoursePrerequisite VALUES ('MIS3301', 'CSC1400');
INSERT INTO CoursePrerequisite VALUES ('MIS3301', 'MGT3301');
INSERT INTO CoursePrerequisite VALUES ('MIS3302', 'MIS3301');

INSERT INTO CoursePrerequisite VALUES ('MKT3301', 'ACC2301');
INSERT INTO CoursePrerequisite VALUES ('MKT3301', 'EGR2302');
INSERT INTO CoursePrerequisite VALUES ('MKT3302', 'MKT3301');
INSERT INTO CoursePrerequisite VALUES ('MKT3303', 'MKT3301');
INSERT INTO CoursePrerequisite VALUES ('MKT4304', 'MKT3301');
INSERT INTO CoursePrerequisite VALUES ('MKT4304', 'MTH3301');
INSERT INTO CoursePrerequisite VALUES ('MKT4305', 'MGT3301');
INSERT INTO CoursePrerequisite VALUES ('MKT4305', 'MKT3302');

INSERT INTO CoursePrerequisite VALUES ('MTH2301', 'MTH1403');
INSERT INTO CoursePrerequisite VALUES ('MTH2303', 'MTH2301');
INSERT INTO CoursePrerequisite VALUES ('MTH2304', 'MTH2303');
INSERT INTO CoursePrerequisite VALUES ('MTH3301', 'MTH2301');
INSERT INTO CoursePrerequisite VALUES ('MTH3302', 'MTH2304');

INSERT INTO CoursePrerequisite VALUES ('PHI2301', 'ENG1301');

INSERT INTO CoursePrerequisite VALUES ('PHY1401', 'MTH1403');
INSERT INTO CoursePrerequisite VALUES ('PHY1402', 'PHY1401');

INSERT INTO CoursePrerequisite VALUES ('PSC2301', 'ENG1301');

INSERT INTO CoursePrerequisite VALUES ('SSC2401', 'MTH1388');
INSERT INTO CoursePrerequisite VALUES ('SSC3303', 'SOC1301');
INSERT INTO CoursePrerequisite VALUES ('SSC4302', 'SSC3303');

INSERT INTO CoursePrerequisite VALUES ('SSK1212', 'SSK1211');
INSERT INTO CoursePrerequisite VALUES ('SSK1213', 'ENG1301');
INSERT INTO CoursePrerequisite VALUES ('SSK1213', 'SSK1212');

-- Catalog 2006 SSK courses prereq
INSERT INTO CoursePrerequisite VALUES ('SSK1202', 'SSK1201');
INSERT INTO CoursePrerequisite VALUES ('SSK1202', 'SSK1203');
INSERT INTO CoursePrerequisite VALUES ('SSK1204', 'SSK1201');
INSERT INTO CoursePrerequisite VALUES ('SSK1204', 'SSK1203');

-- Populate table CourseCorequisite
INSERT INTO CourseCorequisite VALUES ('CSC2302', 'MTH1304');
INSERT INTO CourseCorequisite VALUES ('EGR2402', 'MTH2304');
INSERT INTO CourseCorequisite VALUES ('EGR3331', 'PHY1402');


-- Populate table StandingPrerequesite
INSERT INTO StandingPrerequisite VALUES('HUM2301',2);
INSERT INTO StandingPrerequisite VALUES('HUM2302',2);
INSERT INTO StandingPrerequisite VALUES('HUM2303',2);
INSERT INTO StandingPrerequisite VALUES('HUM2305',2);
INSERT INTO StandingPrerequisite VALUES('HUM2306',2);

-- Populate table CourseEquivalent
INSERT INTO CourseEquivalent VALUES ('HUM2303', 'HUM2302');
INSERT INTO CourseEquivalent VALUES ('HUM2304', 'HUM2301');
INSERT INTO CourseEquivalent VALUES ('ARB2304', 'LIT2304');

-- Populate table MajorArea
-- General Engineering major
INSERT INTO MajorArea VALUES ('REMTH', 'Mathematics Requirements', 'BSGE', 13);
INSERT INTO MajorArea VALUES ('ELMBS', 'Mathematics and Basic Sciences Electives', 'BSGE', 7);
INSERT INTO MajorArea VALUES ('REESC', 'Engineering Sciences', 'BSGE', 26);
INSERT INTO MajorArea VALUES ('REETO', 'Engineering Topics', 'BSGE', 33);
INSERT INTO MajorArea VALUES ('CCFAS', 'Foundations for Academic Success', 'BSGE', 2);
INSERT INTO MajorArea VALUES ('CCAOF', 'Arabic or French', 'BSGE', 6);
INSERT INTO MajorArea VALUES ('CCCOM', 'Communication', 'BSGE', 3);
INSERT INTO MajorArea VALUES ('CCENG', 'English', 'BSGE', 6);
INSERT INTO MajorArea VALUES ('CCHPS', 'History or Politcal Science', 'BSGE', 3);
INSERT INTO MajorArea VALUES ('CCHM1', 'Humanities I', 'BSGE', 3);
INSERT INTO MajorArea VALUES ('CCHM2', 'Humanities II', 'BSGE', 3);
INSERT INTO MajorArea VALUES ('CCSSC', 'Social Sciences', 'BSGE', 3);
-- Computer Science major
INSERT INTO MajorArea VALUES ('REMTH', 'Mathematics Requirements', 'BSCSC', 13);
INSERT INTO MajorArea VALUES ('REBSC', 'Basic Science Requirements', 'BSCSC', 8);
INSERT INTO MajorArea VALUES ('ELMBS', 'Mathematics and Basic Sciences Electives', 'BSCSC', 9);
INSERT INTO MajorArea VALUES ('REENG', 'Engineering Student Requirements', 'BSCSC', 22);
INSERT INTO MajorArea VALUES ('RECSC', 'Computer Science Major Requirements', 'BSCSC', 24);
INSERT INTO MajorArea VALUES ('ELACS', 'Advanced Computer Science Electives', 'BSCSC', 9);
INSERT INTO MajorArea VALUES ('ELCSC', 'Computer Science Electives', 'BSCSC', 6);
INSERT INTO MajorArea VALUES ('CCFAS', 'Foundations for Academic Success', 'BSCSC', 2);
INSERT INTO MajorArea VALUES ('CCAOF', 'Arabic or French', 'BSCSC', 6);
INSERT INTO MajorArea VALUES ('CCCOM', 'Communication', 'BSCSC', 3);
INSERT INTO MajorArea VALUES ('CCENG', 'English', 'BSCSC', 6);
INSERT INTO MajorArea VALUES ('CCHPS', 'History or Politcal Science', 'BSCSC', 3);
INSERT INTO MajorArea VALUES ('CCHM1', 'Humanities I', 'BSCSC', 3);
INSERT INTO MajorArea VALUES ('CCHM2', 'Humanities II', 'BSCSC', 3);
INSERT INTO MajorArea VALUES ('CCSSC', 'Social Sciences', 'BSCSC', 3);    
-- Engineering and Management Science Major
INSERT INTO MajorArea VALUES ('REMTH', 'Mathematics Requirements', 'BSEMS', 13);
INSERT INTO MajorArea VALUES ('REBSC', 'Basic Science Requirements', 'BSEMS', 12);
INSERT INTO MajorArea VALUES ('ELMBS', 'Mathematics and Basic Sciences Electives', 'BSEMS', 7);
INSERT INTO MajorArea VALUES ('REECS', 'Engineering Sciences Requirements', 'BSEMS', 26);
INSERT INTO MajorArea VALUES ('REEMT', 'Engineering Management Topics Requirements', 'BSEMS', 33);
INSERT INTO MajorArea VALUES ('CCFAS', 'Foundations for Academic Success', 'BSEMS', 2);
INSERT INTO MajorArea VALUES ('CCAOF', 'Arabic or French', 'BSEMS', 6);
INSERT INTO MajorArea VALUES ('CCCOM', 'Communication', 'BSEMS', 3);
INSERT INTO MajorArea VALUES ('CCENG', 'English', 'BSEMS', 6);
INSERT INTO MajorArea VALUES ('CCHPS', 'History or Politcal Science', 'BSEMS', 3);
INSERT INTO MajorArea VALUES ('CCHM1', 'Humanities I', 'BSEMS', 3);
INSERT INTO MajorArea VALUES ('CCHM2', 'Humanities II', 'BSEMS', 3);
INSERT INTO MajorArea VALUES ('CCSSC', 'Social Sciences', 'BSEMS', 3);

-- Populate table MajorThematicArea
-- General Engineering
INSERT INTO MajorThematicArea VALUES ('GECSC', 'Computer Science for General 
		Engineering', 'BSGE', 15);
INSERT INTO MajorThematicArea VALUES ('GELSC', 'Logistics and Supply Chain Management 
		for General Engineering', 'BSGE', 15);
INSERT INTO MajorThematicArea VALUES ('GEIEN', 'International Engineering for General 
		Engineering', 'BSGE', 15);
-- Engineering and Management Science
INSERT INTO MajorThematicArea VALUES ('EMCSC', 'Computer Science for Engineering and Management 
		Science', 'BSEMS', 15);
INSERT INTO MajorThematicArea VALUES ('EMLSC', 'Logistics and Supply Chain Management 
		for Engineering and Management Science', 'BSEMS', 15);
INSERT INTO MajorThematicArea VALUES ('EMFIN', 'Finance for Engineering and	
		Management Science', 'BSEMS', 15);
INSERT INTO MajorThematicArea VALUES ('EMIEN', 'International Engineering for Engineering and 
		Management Science', 'BSEMS', 15);

-- Populate table MinorArea
-- Populate Computer Science Minor Data
INSERT INTO MinorArea VALUES('CSREQ', 'Computer Science Minor Required Courses', 'MNCSC',
		6);
INSERT INTO MinorArea VALUES('CSELC', 'Computer Science Minor Elective Courses', 'MNCSC',
		9);
-- Populate General Engineering Minor Data
INSERT INTO MinorArea VALUES('GEREQ', 'General Engineering Minor Required Courses', 'MNGE',
		7);
INSERT INTO MinorArea VALUES('GEELC', 'General Engineering Minor Elective Courses', 'MNGE',
		8);
-- Populate Mathematics Minor Data
INSERT INTO MinorArea VALUES('MTREQ', 'Mathematics Minor Required Courses', 'MNMTH',
		6);
INSERT INTO MinorArea VALUES('MTELC', 'Mathematics Minor Elective Courses', 'MNMTH',
		9);
INSERT INTO MinorArea VALUES('REWMS', 'Required Courses for Women\'s Studies Minor', 'MNWMS',
		12);
	
-- Populate table StudentMajor
INSERT INTO StudentMajor VALUES (11111, 'BSGE', NULL);
INSERT INTO StudentMajor VALUES (11112, 'BSCSC', NULL);
    
-- Populate table StudentMinor
INSERT INTO StudentMinor VALUES (11111, 'MNCSC');
INSERT INTO StudentMinor VALUES (11112, 'MNWMS');

-- Populate table CourseMajorArea
-- major in General Engineering
INSERT INTO CourseMajorArea VALUES ('MTH1403', 'REMTH', 'BSGE', 'MTH1311');
INSERT INTO CourseMajorArea VALUES ('MTH2301', 'REMTH', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('MTH2303', 'REMTH', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('MTH2304', 'REMTH', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('BIO1401', 'ELMBS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('BIO1402', 'ELMBS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('CHE1402', 'ELMBS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('MTH1304', 'ELMBS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('MTH3302', 'ELMBS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR1201', 'REESC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR1210', 'REESC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR2301', 'REESC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR2311', 'REESC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR2312', 'REESC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR2402', 'REESC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR3301', 'REESC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR3302', 'REESC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR3304', 'REESC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC1401', 'REETO', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC2302', 'REETO', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR2302', 'REETO', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR3306', 'REETO', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR3331', 'REETO', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR3401', 'REETO', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR4300', 'REETO', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR4402', 'REETO', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('FAS0210', 'CCFAS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('FAS1220', 'CCFAS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('ARB1310', 'CCAOF', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('ARB1320', 'CCAOF', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('FRN2310', 'CCAOF', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('FRN3310', 'CCAOF', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('COM1301', 'CCCOM', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('ENG1301', 'CCENG', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('ENG2303', 'CCENG', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('HIS1301', 'CCHPS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('HIS1302', 'CCHPS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('HIS2301', 'CCHPS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('PSC2301', 'CCHPS', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2301', 'CCHM1', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2302', 'CCHM1', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2303', 'CCHM1', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2304', 'CCHM1', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('LIT2301', 'CCHM1', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('LIT2304', 'CCHM1', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('LIT2305', 'CCHM1', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2305', 'CCHM2', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2306', 'CCHM2', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('PHI2301', 'CCHM2', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('PHI2302', 'CCHM2', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('ECO1300', 'CCSSC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('GEO1301', 'CCSSC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('PSY1301', 'CCSSC', 'BSGE', NULL);
INSERT INTO CourseMajorArea VALUES ('SOC1301', 'CCSSC', 'BSGE', NULL);
-- major in Computer Science
INSERT INTO CourseMajorArea VALUES ('FAS0210', 'CCFAS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('FAS1220', 'CCFAS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('ARB1310', 'CCAOF', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('ARB1320', 'CCAOF', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('FRN2310', 'CCAOF', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('FRN3310', 'CCAOF', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('COM1301', 'CCCOM', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('ENG1301', 'CCENG', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('ENG2303', 'CCENG', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('HIS1301', 'CCHPS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('HIS1302', 'CCHPS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('HIS2301', 'CCHPS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('PSC2301', 'CCHPS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2301', 'CCHM1', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2302', 'CCHM1', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2303', 'CCHM1', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2304', 'CCHM1', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('LIT2301', 'CCHM1', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('LIT2304', 'CCHM1', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('LIT2305', 'CCHM1', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2305', 'CCHM2', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('HUM2306', 'CCHM2', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('PHI2301', 'CCHM2', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('PHI2302', 'CCHM2', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('ECO1300', 'CCSSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('GEO1301', 'CCSSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('PSY1301', 'CCSSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('SOC1301', 'CCSSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('MTH1304', 'REMTH', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('MTH1403', 'REMTH', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('MTH2301', 'REMTH', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('MTH3301', 'REMTH', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('PHY1401', 'REBSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('PHY1402', 'REBSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('BIO1401', 'ELMBS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('BIO1402', 'ELMBS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CHE1401', 'ELMBS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CHE1402', 'ELMBS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('MTH2303', 'ELMBS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('MTH2304', 'ELMBS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR2301', 'REENG', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC1401', 'REENG', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC2302', 'REENG', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR2302', 'REENG', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR3331', 'REENG', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR4300', 'REENG', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('EGR4402', 'REENG', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC2303', 'RECSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC2304', 'RECSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3315', 'RECSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3323', 'RECSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3324', 'RECSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3326', 'RECSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3351', 'RECSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3352', 'RECSC', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3309', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3315', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3323', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3324', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3325', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3326', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3327', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3328', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3341', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3351', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3352', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3353', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3354', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3355', 'ELACS', 'BSCSC', NULL);
INSERT INTO CourseMajorArea VALUES ('CSC3356', 'ELACS', 'BSCSC', NULL);

-- Populate table CourseMinorArea
-- minor in Computer Science
INSERT INTO CourseMinorArea VALUES ('CSC2302', 'CSREQ', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC2303', 'CSREQ', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC2304', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3309', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3315', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3323', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3324', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3325', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3326', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3327', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3328', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3341', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3351', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3352', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3353', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3354', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3355', 'CSELC', 'MNCSC', NULL);
INSERT INTO CourseMinorArea VALUES ('CSC3356', 'CSELC', 'MNCSC', NULL);
-- minor in Women's Studies
INSERT INTO CourseMinorArea VALUES ('SSC2315', 'REWMS', 'MNWMS', NULL);
INSERT INTO CourseMinorArea VALUES ('SSC3311', 'REWMS', 'MNWMS', NULL);
INSERT INTO CourseMinorArea VALUES ('SSC3315', 'REWMS', 'MNWMS', NULL);
INSERT INTO CourseMinorArea VALUES ('SSC3316', 'REWMS', 'MNWMS', NULL);

-- Populate table Enroll
INSERT INTO Enroll VALUES (11111, 'MTH1304', 'P');
INSERT INTO Enroll VALUES (11111, 'MTH1311', 'P');
INSERT INTO Enroll VALUES (11111, 'MTH1312', 'C');
INSERT INTO Enroll VALUES (11111, 'PHY1401', 'P');
INSERT INTO Enroll VALUES (11111, 'CHE1401', 'C');
INSERT INTO Enroll VALUES (11111, 'EGR1201', 'P');
INSERT INTO Enroll VALUES (11111, 'CSC1401', 'P');
INSERT INTO Enroll VALUES (11111, 'CSC2302', 'P');
INSERT INTO Enroll VALUES (11111, 'CSC2303', 'C');
INSERT INTO Enroll VALUES (11111, 'FAS0210', 'P');
INSERT INTO Enroll VALUES (11111, 'FAS1220', 'P');
INSERT INTO Enroll VALUES (11111, 'FRN2310', 'P');
INSERT INTO Enroll VALUES (11111, 'FRN3310', 'P');
INSERT INTO Enroll VALUES (11111, 'COM1301', 'C');
INSERT INTO Enroll VALUES (11111, 'ENG1301', 'P');
INSERT INTO Enroll VALUES (11111, 'HIS1302', 'P');
INSERT INTO Enroll VALUES (11111, 'ACC2301', 'P');
INSERT INTO Enroll VALUES (11112, 'MTH1304', 'C');
INSERT INTO Enroll VALUES (11112, 'PHY1401', 'C');
INSERT INTO Enroll VALUES (11112, 'CSC1401', 'C');
INSERT INTO Enroll VALUES (11112, 'ENG1301', 'C');
INSERT INTO Enroll VALUES (11112, 'SSC2315', 'C');