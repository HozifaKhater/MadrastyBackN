using API.Controllers;
using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDatabaseContext, DatabaseContext>();
builder.Services.AddScoped<IAbsenceCaseDetailsService, AbsenceCaseDetailsService>();
builder.Services.AddScoped<IAbsencePermitEznService, AbsencePermitEznService>();
builder.Services.AddScoped<IAbsenceService, AbsenceService>();
builder.Services.AddScoped<IAbsenceStatisticsService, AbsenceStatisticsService>();
builder.Services.AddScoped<IAbsenseCaseService, AbsenceCaseService>();
builder.Services.AddScoped<IActivityService, ActivityService>();
builder.Services.AddScoped<IAdvertimentService, AdvertismentService>();
builder.Services.AddScoped<IAlertService, AlertService>();
builder.Services.AddScoped<IBehavioralStatusService, BehavioralStatusService>();
builder.Services.AddScoped<IBehaviourStatusDetailsService, BehaviourStatusDetailsService>();
builder.Services.AddScoped<IBehaviourStatusService, BehaviourStatusService>();
builder.Services.AddScoped<IBoardService, BoardService>();
builder.Services.AddScoped<IBoardTypeService, BoardTypeService>();
builder.Services.AddScoped<IBorrowedBookService, BorrowedBookService>();
builder.Services.AddScoped<ICatchRecieptService, CatchRecieptService>();
builder.Services.AddScoped<IChangeBranchService, ChangeBranchService>();
builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<ICorridorsService, CorridorsService>();
builder.Services.AddScoped<ICorridorSupervisionService, CorridorSupervisionService>();
builder.Services.AddScoped<ICorrMeetingService, CorrMeetingService>();
builder.Services.AddScoped<IDefinitionService, DefinitionService>();
builder.Services.AddScoped<IDepartmanetService, DepartmentService>();
builder.Services.AddScoped<IDivisionService, DivisionService>();
builder.Services.AddScoped<IEmployeeeUserPrivilige, EmployeeUserPrivilige>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEvaluationItemService, EvaluationItemService>();
builder.Services.AddScoped<IEvaluationSettingsService, EvaluationSettingService>();
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<IExcellentStudentService, ExcellentStudentService>();
builder.Services.AddScoped<IFailureCasesService, FailureCasesService>();
builder.Services.AddScoped<IGdwel7ssService, Gdwel7ssService>();
builder.Services.AddScoped<IGoodBadStudentsCardService, GoodBadStudentsCardService>();
builder.Services.AddScoped<IGroupMeetingService, GroupMeetingService>();
builder.Services.AddScoped<IHealthCasesService, HealthCasesService>();
builder.Services.AddScoped<IHolidaysAndFeastsService, HolidaysAndFeastsService>();
builder.Services.AddScoped<IIndividualCasesService, IndividualCasesService>();
builder.Services.AddScoped<IInstructionsService, InstructionsService>();
builder.Services.AddScoped<IJobDetailsService, JobDetailsService>();
builder.Services.AddScoped<IJobMasterService, JobMasterService>();
builder.Services.AddScoped<ILectureService, LectureService>();
builder.Services.AddScoped<ILevelsService, LevelsService>();
builder.Services.AddScoped<ILibraryService, LibraryService>();
builder.Services.AddScoped<IMaintenanceService, MaintenanceService>();
builder.Services.AddScoped<IMeetingTypeService, MeetingTypeService>();
builder.Services.AddScoped<IMonthValueService, MonthValueService>();
builder.Services.AddScoped<INewsService, NewsService>();
builder.Services.AddScoped<INewWorkService, NewWorkService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IObservationService, ObservationService>();
builder.Services.AddScoped<IOtherStudentsSlidesService, OtherStudentsSlidesService>();
builder.Services.AddScoped<IPaymentRecieptService, PaymentRecieptService>();
builder.Services.AddScoped<IPsychologistPlanService, PsychologistPlanService>();
builder.Services.AddScoped<IPublicationDetailsService, PublicationDetailsService>();
builder.Services.AddScoped<IPublcationService, PublicationServcie>();
builder.Services.AddScoped<IRegimeCouncilStudentService, RegimeCouncilStudentService>();
builder.Services.AddScoped<ISchoolDataService, SchoolDataService>();
builder.Services.AddScoped<ISchoolPartyService, SchoolPartyService>();
builder.Services.AddScoped<ISchoolYearDataService, SchoolYearDataService>();
builder.Services.AddScoped<ISingalIrConnectionService, SingalIrConnectionService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IStudentStatusBehaviourReportService, StudentStatusBehaviourReportService>();
builder.Services.AddScoped<ITa7dierMasterService, Ta7dierMasterService>();
builder.Services.AddScoped<ITakeemMasterService, TakeemMasterService>();
builder.Services.AddScoped<IUserPrivilegesService, UserPrivilegesService>();
builder.Services.AddScoped<IWorkPlanService, WorkPlanService>();
builder.Services.AddScoped<ISupervisorOpinionService, SupervisorOpinionService>();
builder.Services.AddScoped<IVisitService, VisitService>();
builder.Services.AddScoped<ISwotService, SwotService>();
builder.Services.AddScoped<IStudentParentMeetingService, StudentParentMeetingService>();
builder.Services.AddScoped<IStudentPremService, StudentPremService>();
builder.Services.AddScoped<IPhaseService, PhaseService>();
builder.Services.AddScoped<IExcellentStudentService, ExcellentStudentService>();
builder.Services.AddScoped<IAbsenseCaseService, AbsenceCaseService>();
builder.Services.AddScoped<IAbsenceCaseDetailsService, AbsenceCaseDetailsService>();
builder.Services.AddScoped<IHealthCasesService, HealthCasesService>();
builder.Services.AddScoped<ISpeakingDisorderService, SpeakingDisorderService>();
builder.Services.AddScoped<ISpeakingDisorderDetailsFirstService, SpeakingDisorderDetailsFirstService>();
builder.Services.AddScoped<ISpeakingDisorderDetailsSecondService, SpeakingDisorderDetailsSecondService>();
builder.Services.AddScoped<IFailureCasesService, FailureCasesService>();
builder.Services.AddScoped<IStatusService, StatusService>();
builder.Services.AddScoped<IAchievementLevelService, AchievementLevelService>();
builder.Services.AddScoped<IStudentTransferService, StudentTransferService>();
builder.Services.AddScoped<IStudentLeaveService, StudentLeaveService>();
builder.Services.AddScoped<ISuggestionService, SuggestionService>();
builder.Services.AddScoped<IRestToRedoService, RestToRedoService>();
builder.Services.AddScoped<IAccusedStudentInGuiltService, AccusedStudentInGuiltService>();
builder.Services.AddScoped<IGuiltService, GuiltService>();
builder.Services.AddScoped<ISonOfMartyrsService, SonOfMartyrsService>();
builder.Services.AddScoped<ISpecialStudentService, SpecialStudentService>();
builder.Services.AddScoped<IOtherStudentsSlidesService, OtherStudentsSlidesService>();
builder.Services.AddScoped<IGuideService, GuideService>();
builder.Services.AddScoped<ITestMetricService, TestMetricService>();
builder.Services.AddScoped<IRegimeCouncilStudentService, RegimeCouncilStudentService>();
builder.Services.AddScoped<IMentalityInquiriesService, MentalityInquiriesService>();
builder.Services.AddScoped<ISocialWorkerService, SocialWorkerService>(); 
builder.Services.AddScoped<IDelayService, DelayService>();
builder.Services.AddScoped<ISubjectService, SubjectService>();
builder.Services.AddScoped<IParentsMeetingsService, ParentsMeetingsService>();
builder.Services.AddScoped<IMessagesViewModelService, MessagesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
