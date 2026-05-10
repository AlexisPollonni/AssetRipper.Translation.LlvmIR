using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L20initialize_auxv_onceEv")]
[DemangledName("__llvm_libc_20_1_2_::initialize_auxv_once()")]
internal static partial class initialize_auxv_once
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void>)(&Invoke));

	public unsafe static void Invoke()
	{
		anon_589mcc anon_589mcc2 = default(anon_589mcc);
		void* ptr = null;
		long num = 0L;
		int num2 = 0;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		void* ptr2 = null;
		sbyte b = 0;
		long num3 = 0L;
		if (cxa_atexit.__pointer == null)
		{
			return;
		}
		llvm_lifetime_start_p0.Invoke(8L, &anon_589mcc2);
		int num4;
		int num7;
		unchecked
		{
			*(IntPtr*)(&anon_589mcc2) = unchecked((nint)(-6148914691236517206L));
			AuxvMMapGuard_AuxvMMapGuard_6sti8k.Invoke(&anon_589mcc2);
			if (!AuxvMMapGuard_allocated_const.Invoke(&anon_589mcc2))
			{
				num4 = 1;
				goto IL_02a8;
			}
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = AuxvMMapGuard_get_const.Invoke(&anon_589mcc2);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 1016L;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			long num5 = (long)ptr;
			long num6 = num;
			num2 = ((delegate*<int, long, long, long, long, int>)prctl.__pointer)(1096112214, num5, num6, 0L, 0L);
			if (num2 >= 0)
			{
				AuxvMMapGuard_submit_to_global.Invoke(&anon_589mcc2);
				num4 = 1;
				goto IL_0276;
			}
			llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
			*(int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2) = -1431655766;
			AuxvFdGuard_AuxvFdGuard_pkv6db.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
			if (!AuxvFdGuard_valid_const.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2))
			{
				num4 = 1;
				goto IL_025d;
			}
			llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = ptr;
			Errno_operator_int_dntwiy.Invoke(libc_errno.Pointer, 0);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = 0;
			while (num != 0L)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = ((delegate*<int, void*, long, long>)read.__pointer)(AuxvFdGuard_get_const.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2), ptr2, num);
				if (num3 <= 0L)
				{
					if (Errno_operator_int_exthys.Invoke(libc_errno.Pointer) == 4)
					{
						num4 = 2;
					}
					else
					{
						if (num3 == -1L)
						{
							b = 1;
						}
						num4 = 3;
					}
				}
				else
				{
					ptr2 = (byte*)ptr2 + num3;
					num -= num3;
					num4 = 0;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				num7 = num4;
				if (num7 == 0 || num7 == 2)
				{
					continue;
				}
				goto IL_0216;
			}
			goto IL_0225;
		}
		IL_02d0:
		throw null;
		IL_0225:
		if ((b & 1) != 1)
		{
			AuxvMMapGuard_submit_to_global.Invoke(&anon_589mcc2);
		}
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(8L, &ptr2);
		num4 = 0;
		goto IL_025d;
		IL_025d:
		AuxvFdGuard_AuxvFdGuard_jzbs6x.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
		goto IL_0276;
		IL_0276:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		goto IL_02a8;
		IL_02a8:
		AuxvMMapGuard_AuxvMMapGuard_zmckj4.Invoke(&anon_589mcc2);
		llvm_lifetime_end_p0.Invoke(8L, &anon_589mcc2);
		switch (num4)
		{
		case 0:
		case 1:
			return;
		}
		goto IL_02d0;
		IL_0216:
		if (num7 == 3)
		{
			goto IL_0225;
		}
		goto IL_02d0;
	}
}
