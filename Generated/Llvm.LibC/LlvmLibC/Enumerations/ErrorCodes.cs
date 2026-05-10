using LlvmLibC.Helpers;

namespace LlvmLibC.Enumerations;

[MangledName("_ZTSN19__llvm_libc_20_1_2_10scanf_core10ErrorCodesE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::ErrorCodes")]
public enum ErrorCodes
{
	READ_OK = 0,
	FILE_READ_ERROR = -1,
	FILE_STATUS_ERROR = -2,
	MATCHING_FAILURE = -3,
	ALLOCATION_FAILURE = -4
}
