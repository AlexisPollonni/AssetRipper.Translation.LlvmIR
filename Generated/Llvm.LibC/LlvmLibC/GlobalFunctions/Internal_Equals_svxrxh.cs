using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_Equals_svxrxh
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internaleqENS1_9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEEES6_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator==(__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>, __llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>)")]
	[CleanName("Internal_Equals")]
	public unsafe static bool Invoke([MangledName("a.coerce0")] long A, [MangledName("a.coerce1")] long B, [MangledName("b.coerce0")] long B_coerce0, [MangledName("b.coerce1")] long B_coerce1)
	{
		Fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud = default(Fputil_internal_FPRepImpl_jrxud9);
		Fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud2 = default(Fputil_internal_FPRepImpl_jrxud9);
		Int128 @int = default(Int128);
		Int128 y = default(Int128);
		unchecked
		{
			*(long*)(&fputil_internal_FPRepImpl_jrxud) = A;
			((long*)(&fputil_internal_FPRepImpl_jrxud))[1] = B;
			*(long*)(&fputil_internal_FPRepImpl_jrxud2) = B_coerce0;
			((long*)(&fputil_internal_FPRepImpl_jrxud2))[1] = B_coerce1;
			Struct_fiz2nb struct_fiz2nb = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_internal_FPRepImpl_jrxud);
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 x = @int;
			Struct_fiz2nb struct_fiz2nb4 = FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval.Invoke(&fputil_internal_FPRepImpl_jrxud2);
			Int128* num3 = &y;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			*(long*)num3 = struct_fiz2nb5.field_0;
			byte* num4 = (byte*)(&y) + 8u;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			*(long*)num4 = struct_fiz2nb6.field_1;
			return NumericHelper.IntCmpEq(x, y);
		}
	}
}
