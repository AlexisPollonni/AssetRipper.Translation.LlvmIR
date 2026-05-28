using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_RightShift_7akpcn
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalrsENS1_9FPStorageILNS0_6FPTypeE4EE11SignificandEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator>>(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::Significand, int)")]
	[CleanName("Internal_RightShift")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("a.coerce0")] long A, [MangledName("a.coerce1")][CleanName("Shift")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::Significand")] long Shift_eq4gfg, [MangledName("shift")][CleanName("Shift")][NativeType("int")] int Shift_s8dkmd)
	{
		Fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua = default(Fputil_internal_FPRepSem_f94eua);
		Fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(Fputil_internal_FPRepSem_f94eua);
		Int128 x = default(Int128);
		unchecked
		{
			*(long*)(&fputil_internal_FPRepSem_f94eua2) = A;
			((long*)(&fputil_internal_FPRepSem_f94eua2))[1] = Shift_eq4gfg;
			Struct_fiz2nb struct_fiz2nb = TypedInt_unsigned_int128_to_storage_type_y7zepn.Invoke(&fputil_internal_FPRepSem_f94eua2);
			Int128* num = &x;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&x) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 @int = NumericHelper.ShiftRightLogical(x, (Int128)(UInt128)(uint)Shift_s8dkmd);
			Significand_Constructor_j3ersh.Invoke(&fputil_internal_FPRepSem_f94eua, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&fputil_internal_FPRepSem_f94eua.FPStorage.field_0);
		}
	}
}
