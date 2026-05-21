using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_BitwiseOr_s6pzhg
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalorENS1_9FPStorageILNS0_6FPTypeE3EE11SignificandES5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator|(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand)")]
	[CleanName("Internal_BitwiseOr")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("a.coerce0")] long A, [MangledName("a.coerce1")] long B, [MangledName("b.coerce0")] long B_coerce0, [MangledName("b.coerce1")] long B_coerce1)
	{
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua3 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua);
		Int128 @int = default(Int128);
		Int128 y = default(Int128);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua2) = A;
			((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua2))[1] = B;
			*(long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua3) = B_coerce0;
			((long*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua3))[1] = B_coerce1;
			Struct_fiz2nb struct_fiz2nb = TypedInt_unsigned_int128_to_storage_type_b7v9xe.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua2);
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 x = @int;
			Struct_fiz2nb struct_fiz2nb4 = TypedInt_unsigned_int128_to_storage_type_b7v9xe.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua3);
			Int128* num3 = &y;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			*(long*)num3 = struct_fiz2nb5.field_0;
			byte* num4 = (byte*)(&y) + 8u;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			*(long*)num4 = struct_fiz2nb6.field_1;
			Int128 int2 = NumericHelper.BitwiseOr(x, y);
			Significand_Constructor_rhfmvq.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua, *(long*)(&int2), ((long*)(&int2))[1]);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua.FPStorage.field_0);
		}
	}
}
