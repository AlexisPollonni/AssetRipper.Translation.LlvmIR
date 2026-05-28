using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Openfile
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8openfileEPKcS1_")]
	[DemangledName("__llvm_libc_20_1_2_::openfile(char const*, char const*)")]
	public unsafe static Struct_yx4nca Invoke([MangledName("path")][NativeType("char const*")] void* Path, [MangledName("mode")][NativeType("char const*")] void* Mode)
	{
		Cpp_optional_char_OptionalStorage cpp_optional_char_OptionalStorage = default(Cpp_optional_char_OptionalStorage);
		int num = 0;
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		void* buffer = null;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		void* exp = null;
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = File_mode_flags.Invoke(Mode);
		unchecked
		{
			if (num == 0)
			{
				Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, 22);
				Expected_File_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 0L;
				if ((num & 4) != 0)
				{
					num2 = 1088L;
					num2 = (((num & 8) == 0) ? (num2 | 1L) : (num2 | 2L));
				}
				else if ((num & 2) != 0)
				{
					num2 = 576L;
					num2 = (((num & 8) == 0) ? (num2 | 1L) : (num2 | 2L));
				}
				else
				{
					num2 = (((num & 8) == 0) ? (num2 | 0L) : (num2 | 2L));
				}
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = 438L;
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = Syscall_impl_int_char_const_long_long.Invoke(2L, Path, num2, 438L);
				if (num4 < 0)
				{
					Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, checked(-num4));
					Expected_File_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &buffer);
					buffer = (void*)12297829382473034410uL;
					Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
					*(sbyte*)(&anon_izyfb) = -86;
					AllocChecker_Constructor.Invoke(&anon_izyfb);
					buffer = NewArray.Invoke(1024L, &anon_izyfb);
					int num5;
					if (!AllocChecker_ToBoolean.Invoke(&anon_izyfb))
					{
						Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3, 12);
						Expected_File_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3.field_0);
						num5 = 1;
					}
					else
					{
						num5 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
					switch (num5)
					{
					case 0:
					{
						Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
						*(sbyte*)(&anon_izyfb2) = -86;
						AllocChecker_Constructor.Invoke(&anon_izyfb2);
						Llvm_lifetime_start_p0.Invoke(8L, &exp);
						void* ptr = New.Invoke(128L, &anon_izyfb2);
						nint num6;
						if (ptr == null)
						{
							num6 = 0;
						}
						else
						{
							LinuxFile_Constructor.Invoke((LinuxFile*)ptr, num4, buffer, 1024L, 0, Owned: true, num);
							num6 = (nint)ptr;
						}
						exp = (void*)num6;
						if (!AllocChecker_ToBoolean.Invoke(&anon_izyfb2))
						{
							Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4, 12);
							Expected_File_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4.field_0);
						}
						else
						{
							Expected_File_int_Constructor.Invoke(&cpp_optional_char_OptionalStorage, (File_sjnxn4*)exp);
						}
						Llvm_lifetime_end_p0.Invoke(8L, &exp);
						Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
						break;
					}
					}
					Llvm_lifetime_end_p0.Invoke(8L, &buffer);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return *(Struct_yx4nca*)(&cpp_optional_char_OptionalStorage);
		}
	}
}
