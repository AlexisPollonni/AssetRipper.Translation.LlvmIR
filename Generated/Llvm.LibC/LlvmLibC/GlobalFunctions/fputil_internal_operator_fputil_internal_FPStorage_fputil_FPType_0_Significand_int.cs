using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalrsENS1_9FPStorageILNS0_6FPTypeE0EE11SignificandEi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator>>(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand, int)")]
internal static partial class fputil_internal_operator_fputil_internal_FPStorage_fputil_FPType_0_Significand_int
{
	public unsafe static short Invoke([MangledName("a.coerce")] short a, int shift)
	{
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h3 = new fputil_internal_FPRepSem_i7nz4h
		{
			FPStorage = 
			{
				field_0 = a
			}
		};
		fputil_internal_FPStorage_fputil_FPType_0_Significand_Significand_unsigned_short.Invoke(&fputil_internal_FPRepSem_i7nz4h2, unchecked((short)((ushort)fputil_internal_FPStorage_fputil_FPType_0_TypedInt_unsigned_short_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_i7nz4h3) >> shift)));
		return fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0;
	}
}
