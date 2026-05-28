using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_RightShift_ueqxwn
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalrsENS1_9FPStorageILNS0_6FPTypeE0EE11SignificandEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator>>(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand, int)")]
	[CleanName("Internal_RightShift")]
	public unsafe static short Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand")] short A, [MangledName("shift")][NativeType("int")] int Shift)
	{
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h = default(Fputil_internal_FPRepSem_i7nz4h);
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = new Fputil_internal_FPRepSem_i7nz4h
		{
			FPStorage = 
			{
				field_0 = A
			}
		};
		Significand_Constructor_n44wpn.Invoke(&fputil_internal_FPRepSem_i7nz4h, unchecked((short)((ushort)TypedInt_unsigned_short_to_storage_type.Invoke(&fputil_internal_FPRepSem_i7nz4h2) >> Shift)));
		return fputil_internal_FPRepSem_i7nz4h.FPStorage.field_0;
	}
}
