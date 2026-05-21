using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_RightShift_7akpcn
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalrsENS1_9FPStorageILNS0_6FPTypeE4EE11SignificandEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator>>(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::Significand, int)")]
	[CleanName("internal_RightShift")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("a.coerce0")] long a, [MangledName("a.coerce1")][CleanName("shift")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::Significand")] long shift_eq4gfg, [MangledName("shift")][CleanName("shift")][NativeType("int")] int shift_s8dkmd)
	{
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua3 = default(fputil_internal_FPRepSem_f94eua);
		Int128 x = default(Int128);
		unchecked
		{
			*(long*)(&fputil_internal_FPRepSem_f94eua3) = a;
			((long*)(&fputil_internal_FPRepSem_f94eua3))[1] = shift_eq4gfg;
			Struct_fiz2nb struct_fiz2nb = TypedInt_unsigned_int128_to_storage_type_y7zepn.Invoke(&fputil_internal_FPRepSem_f94eua3);
			Int128* num = &x;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&x) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 @int = NumericHelper.ShiftRightLogical(x, (Int128)(UInt128)(uint)shift_s8dkmd);
			Significand_Constructor_j3ersh.Invoke(&fputil_internal_FPRepSem_f94eua2, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&fputil_internal_FPRepSem_f94eua2.FPStorage.field_0);
		}
	}
}
