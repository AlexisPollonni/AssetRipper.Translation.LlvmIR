using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Enumerations;

[MangledName("_ZTS17__rlimit_resource")]
[DemangledName("__rlimit_resource")]
public enum rlimit_resource
{
	RLIMIT_CPU = 0,
	RLIMIT_FSIZE = 1,
	RLIMIT_DATA = 2,
	RLIMIT_STACK = 3,
	RLIMIT_CORE = 4,
	__RLIMIT_RSS = 5,
	RLIMIT_NOFILE = 7,
	__RLIMIT_OFILE = 7,
	RLIMIT_AS = 9,
	__RLIMIT_NPROC = 6,
	__RLIMIT_MEMLOCK = 8,
	__RLIMIT_LOCKS = 10,
	__RLIMIT_SIGPENDING = 11,
	__RLIMIT_MSGQUEUE = 12,
	__RLIMIT_NICE = 13,
	__RLIMIT_RTPRIO = 14,
	__RLIMIT_RTTIME = 15,
	__RLIMIT_NLIMITS = 16,
	__RLIM_NLIMITS = 16
}
